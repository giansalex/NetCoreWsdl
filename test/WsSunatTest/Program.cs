using System;
using System.Diagnostics;
using WsSunat;

namespace WsSunatTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Run();
            Console.WriteLine("Completed!");
            Console.ReadKey(true);
        }

        public static async void Run()
        {
            var s = new SunatWs();
            var filename = await s.Run();
            //Process.Start(filename);
        }
    }
}
