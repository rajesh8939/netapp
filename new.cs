using System;

namespace DotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Core version: 8.0.200");
            Console.WriteLine("Hello, .NET!");
            Console.WriteLine($"Environment: {Environment.GetEnvironmentVariable("ENVIRONMENT")}");

            // You can use any additional packages here
            // For example, using Newtonsoft.Json to serialize an object
            var obj = new { Name = "John", Age = 30 };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            Console.WriteLine($"Serialized JSON: {json}");
        }
    }
}
