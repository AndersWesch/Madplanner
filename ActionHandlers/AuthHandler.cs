
using Repositories;
using Helpers;
using Microsoft.JSInterop;


namespace ActionHandlers;

public class AuthHandler
{
    private readonly IJSRuntime JsRuntime;
    private UserRepository Repository;
    public bool IsSignedIn { get; private set; }

    public AuthHandler(IJSRuntime jsRuntime)
    {
        Repository = new UserRepository();
        JsRuntime = jsRuntime;

        // TODO Lav en Auth service der kan hådntere auth state på tværs af systemet (AddScoped ikke Singleton i program)
        // IsSignedIn = false;
    }

    public async Task InitializeAsync()
    {
        var token = await JsRuntime.InvokeAsync<string>("localStorageFunctions.getItem", "authToken");
        IsSignedIn = !string.IsNullOrEmpty(token) && IsUserSignedIn(Guid.Parse(token));
    }

    public Guid? Login(string email, string password)
    {
        var user = Repository.GetByEmail(email);
        
        if (user == null)
            return null;

        if (user.Password == PasswordHasher.HashPassword(password))
        {
            var token = Guid.NewGuid();

            user.Token = token;
            user.TokenExpiration = DateTime.Now.AddDays(28);
            user.LastLogin = DateTime.Now;

            Repository.Update(user);
            IsSignedIn = true;

            return token;
        }
        
        return null;
    }

    public void Logout()
    {
        IsSignedIn = false;
    }

    private bool IsUserSignedIn(Guid token)
    {   
        var user = Repository.GetBytoken(token);

        // TODO Check expiration
        if (user == null)
            return false;

        return true;
    }
}
