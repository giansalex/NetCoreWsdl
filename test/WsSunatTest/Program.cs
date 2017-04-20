using System;
using WsSunat;

namespace WsSunatTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            var s = new SunatWs();
            s.Run();
            Console.WriteLine("Completed!");
            Console.ReadKey(true);
        }
    }
}
