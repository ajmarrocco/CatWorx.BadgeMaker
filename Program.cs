using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // string greeting = "Hello";
            // string greetin = greeting + " World!";
            // // Console.WriteLine("greeting " + greeting);
            // Console.WriteLine($"greeting {greeting}"); 
            // Console.WriteLine("greeting: {0}", greeting, greetin);
            // How do you find the area of a square? Area = side * side
            // double side = 3.14;
            // double area = side * side;
            // Console.WriteLine("area: {0}", area);
            // Console.WriteLine("area is a {0}", area.GetType());
            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
            // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
            string stringNum = "2";
            Console.WriteLine(stringNum);
            Console.WriteLine(stringNum.GetType());
            // Convert to int
            int intNum = Convert.ToInt16(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());
        }
    }
}
