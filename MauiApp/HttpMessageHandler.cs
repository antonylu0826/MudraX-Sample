namespace MauiApp2
{
    public static partial class HttpMessageHandler
    {
        static readonly System.Net.Http.HttpMessageHandler PlatformHttpMessageHandler;
        public static System.Net.Http.HttpMessageHandler GetMessageHandler() => PlatformHttpMessageHandler;
    }
}
