using ActionHandlers;
using MadPlanner.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register your custom services here
builder.Services.AddSingleton<RetHandler>();
builder.Services.AddSingleton<ProduktHandler>();
builder.Services.AddSingleton<MadplanHandler>();
builder.Services.AddSingleton<IngrediensHandler>();
builder.Services.AddSingleton<TilbudHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
