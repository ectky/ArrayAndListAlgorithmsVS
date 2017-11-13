using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) == 1)
                    {
                        string helper = list[i];
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
