using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using EasyToml.AspNetCore.Extensions;

namespace EasyToml.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var conf = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", true, true)
              .AddTomlFile("config.toml", false)
              .Build();

            Console.WriteLine("build complete");

            var cheildren = conf.GetChildren();
            Console.WriteLine(conf.GetChildren());
            Console.ReadLine();
        }
    }
}
