using ActionHandlers;
using Database;
using MadPlanner.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register your custom services here
builder.Services.AddScoped<RetHandler>();
builder.Services.AddScoped<ProduktHandler>();
builder.Services.AddScoped<MadplanHandler>();
builder.Services.AddScoped<IngrediensHandler>();
builder.Services.AddScoped<TilbudHandler>();

// Register your repositories
builder.Services.AddScoped<IngrediensRepository>();
builder.Services.AddScoped<MadplanRepository>();
builder.Services.AddScoped<ProduktRepository>();
builder.Services.AddScoped<RetRepository>();
builder.Services.AddScoped<UserRepository>();

// Add DbContext and Identity services
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddDefaultTokenProviders();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

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

// Add authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
