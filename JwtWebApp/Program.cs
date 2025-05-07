using JwtWebApp.Components;
using MudBlazor.Services;
using MudraX.Blazor.Jwt.Web.Components.Layout;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudraBlazorServices(supportedCultures: ["en-US", "zh-TW"]);
//Dependency Injection JwtIdentityService
builder.Services.AddJwtTokenAuthentication(options =>
{
    var authority = builder.Configuration["JwtTokenAuth:Authority"];
    options.AuthenticateAddress = $"{authority}/api/Authentication/Authenticate";
    options.BaseAddress = $"{authority}/api";
    options.ODataAddress = $"{authority}/api/odata";
    options.JwtSecret = $"{builder.Configuration["JwtTokenAuth:Secret"]}";
    options.Issuer = $"{builder.Configuration["JwtTokenAuth:Issuer"]}";
    options.TokenKeyName = "ApplicationAccessToken";
    options.ExpiresIn = 660;
});

builder.Services.AddODataConnect(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(AppUserMenu).Assembly);

app.UseMudraBlazorServices();

app.Run();
