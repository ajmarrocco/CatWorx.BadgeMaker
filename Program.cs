using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets employees
            List <string> employees = GetEmployees();
            for (int i = 0; i < employees.Count; i++) 
                {
                    Console.WriteLine(employees[i]);
                }
        }
        static List<string> GetEmployees()
            {
                List<string> employees = new List<string>();
                    while(true)
                    {
                        Console.WriteLine("Please enter a name: ");
                        // Get a name from the console and assign it to a variable
                        string input = Console.ReadLine();
                        // breaks the while loop
                        if(input == "")
                        {
                            break;
                        }
                        employees.Add(input);                        
                    }
                    return employees;
            }
    }
}
