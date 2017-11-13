using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < (int)(list.Count / 2); i++)
            {
                int helper = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = helper;
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
