using CrudTest.Db;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CrudTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .CreateDatabase<CrudTestDbContext>()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
