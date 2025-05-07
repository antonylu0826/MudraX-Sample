using Microsoft.Extensions.Logging;
using MudraX.Blazor.OData.Connect;

namespace MauiApp2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddMudraBlazorServices(supportedCultures: ["en-US", "zh-TW"]);
            //Dependency Injection JwtIdentityService
#if ANDROID && DEBUG
            builder.Services.AddJwtTokenAuthentication(options =>
            {
                options.AuthenticateAddress = $"https://10.0.2.2:5001/api/Authentication/Authenticate";
                options.BaseAddress = $"https://10.0.2.2:5001/api";
                options.ODataAddress = $"https://10.0.2.2:5001/api/odata";
                options.JwtSecret = "2119494c-f002-4dda-9222-ec43b538c631";
                options.Issuer = "My";
                options.TokenKeyName = "MyToken";
                options.ExpiresIn = 60;
                options.HttpClientMessageHandler = HttpMessageHandler.GetMessageHandler();
            });
            builder.Services.AddODataConnect(() => new Dictionary<string, ODataConfig>
            {
                { "Setting1", new ODataConfig { Authority = "https://10.0.2.2:5001"} }
            },
            httpMessageHandler: HttpMessageHandler.GetMessageHandler);
#else
            builder.Services.AddJwtTokenAuthentication(options =>
            {
                options.AuthenticateAddress = $"https://localhost:5001/api/Authentication/Authenticate";
                options.BaseAddress = $"https://localhost:5001/api";
                options.ODataAddress = $"https://localhost:5001/api/odata";
                options.JwtSecret = "2119494c-f002-4dda-9222-ec43b538c631";
                options.Issuer = "My";
                options.TokenKeyName = "MyToken";
                options.ExpiresIn = 60;
            });
            builder.Services.AddODataConnect(() => new Dictionary<string, ODataConfig>
            {
                { "Setting1", new ODataConfig { Authority = "https://localhost:5001"} }
            });
#endif

            builder.Services.AddMudraBlazorServices(supportedCultures: ["en-US", "zh-TW"]);

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
