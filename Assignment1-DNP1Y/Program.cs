using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Assignment1_DNP1Y
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileContext fileContext = new FileContext();
            Console.WriteLine("Start printing in the main:");
            Console.WriteLine(fileContext.Adults.Count);
            Console.WriteLine(fileContext.Adults[0].FirstName);
            Console.WriteLine(fileContext.Adults[0].Age);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}