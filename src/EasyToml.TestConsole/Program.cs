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
              .AddTomlFile("config.json", true)
              .Build();

            Console.ReadLine();
        }
    }
}
