using System;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace CatWorx.BadgeMaker {

    class PeopleFetcher
    {
        // code from GetEmployees() in Program.cs
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {

                Console.WriteLine("Please enter a name: (leave empty to exit): ");

                string firstName = Console.ReadLine();

                if (firstName == "")
                {
                    break;
                }
                // add a Console.ReadLine() for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
                }
                return employees;
        }

        // Gets names from Random User Generator
        public static List<Employee> GetFromApi() {
            List<Employee> employees = new List<Employee>();
            using (WebClient client = new WebClient())
            {
                // Image example
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);
                foreach (JToken token in json.SelectToken("results")) {
                    // Parse JSON data
                    Employee emp = new Employee
                    (
                        token.SelectToken("name.first").ToString(),
                        token.SelectToken("name.last").ToString(),
                        Int32.Parse(token.SelectToken("id.value").ToString().Replace("-", "")),
                        token.SelectToken("picture.large").ToString()
                    );
                    employees.Add(emp);
                }
                return employees;
            }
        }
    }
}