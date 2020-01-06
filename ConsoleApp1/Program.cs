using System;
using WebServerTestMejigs;

namespace ConsoleApp1
{
    class Program
    {
        private static Server listener;
        static void Main(string[] args)
        {
            listener = new Server(args);
            Console.WriteLine("Listening on port 8080 (http://localhost:8080/).");
            Console.WriteLine("Remember to put the files you want to serve in the output folder of the project.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
