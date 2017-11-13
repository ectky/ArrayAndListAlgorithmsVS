using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            bool contains = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                {
                    contains = true;
                }
            }

            if (contains)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
