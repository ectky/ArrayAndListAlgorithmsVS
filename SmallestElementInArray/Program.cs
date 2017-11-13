using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int min = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                min = Math.Min(min, list[i]);
            }

            Console.WriteLine(min);
        }
    }
}
