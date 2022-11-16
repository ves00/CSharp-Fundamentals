using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            var employees = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split(" -> ");

                string company = inputArgs[0];
                string employeeId = inputArgs[1];

                if (!employees.ContainsKey(company))
                {
                    employees.Add(company, new List<string>());
                    employees[company].Add(employeeId);
                }
                else
                {
                    if (!employees[company].Contains(employeeId))
                    {
                        employees[company].Add(employeeId);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var company in employees)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}