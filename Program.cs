using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string greetin = greeting + " World!";
            // Console.WriteLine("greeting " + greeting);
            Console.WriteLine($"greeting {greeting}"); 
            Console.WriteLine("greeting: {0}", greeting, greetin);
        }
    }
}
