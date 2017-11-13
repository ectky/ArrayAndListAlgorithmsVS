using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i+1])
                    {
                        int helper = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = helper;
                        swapped = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
