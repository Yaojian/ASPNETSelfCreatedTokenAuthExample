using Microsoft.AspNetCore.Hosting;

namespace TokenAuthExampleWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup<Startup>();
            var host = builder.Build();
            host.Run();
        }
    }
}