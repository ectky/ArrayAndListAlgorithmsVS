using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> hours = new List<int>();
            List<double> startCapacity = new List<double>();
            int testingHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < usagePerHour.Count; i++)
            {
                hours.Add(0);
                startCapacity.Add(capacities[i]);
            }

            for (int i = 0; i < testingHours; i++)
            {
                for (int j = 0; j < capacities.Count; j++)
                {
                    if (capacities[j] > 0)
                    {
                        capacities[j] -= usagePerHour[j];
                        hours[j]++;
                    }
                }
            }

            for (int i = 0; i < capacities.Count; i++)
            {
                double percentage = capacities[i] / startCapacity[i] * 100;
                if (capacities[i] > 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {capacities[i]:F2} mAh ({percentage:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hours[i]} hours)");
                }
            }
        }
    }
}
