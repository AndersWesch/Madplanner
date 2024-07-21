
namespace Services;

public class Authentication
{
    public bool isAuthenticated { get; set; } = false;

    public Authentication()
    {
        Console.WriteLine("FALSE - CONSTRUCTOR");
        isAuthenticated = false;
    }
}
