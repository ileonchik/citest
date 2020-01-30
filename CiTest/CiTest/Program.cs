using System;
using System.IO;
using CiTest.Database;
using CiTest.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace CiTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter path to the file:");
            
            var path = Console.ReadLine();
            if(!File.Exists(path))
            {
                throw  new FileNotFoundException($"File doesn't exist: {path}");
            }

            XmlStorage.Path = path;
          //  var contracts = XmlStorage.Contracts;
          var configuration = ConfigurationService.GetBuilder().Build();
            CiTestContext context = new  CiTestContext();
            context.Database.Migrate();
            CreateHostBuilder(args).Build().Run();
           
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel().UseStartup<Startup>();
                });
    }
}
