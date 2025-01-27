using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Softplan.Api
{
    public class Program
    {
        public static void Main(string[] args) =>
            CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(UseStartup);

        private static void UseStartup(IWebHostBuilder webBuilder) =>
            webBuilder.UseStartup<Startup>();
    }
}
