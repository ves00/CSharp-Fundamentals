﻿using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            //"{resource} –> {quantity}"

            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;
            }
            foreach (var rqp in resources)
            {
                Console.WriteLine($"{rqp.Key} -> {rqp.Value}");
            }
        }
    }
}
