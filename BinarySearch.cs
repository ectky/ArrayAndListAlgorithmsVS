using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int FindUnmodified(List<int> list, int n)
        {
            int count = 0;
            foreach (int value in list)
            {
                count++;
                if (value == n)
                {
                    break;
                }
            }
            return count;
        }

        static int FindModified(List<int> list, int n)
        {
            int count = 0;
            list.Sort();
            int mid = 0; int low = 0; int high = list.Count - 1;
            while (low <= high)
            {
                count++;
                mid = low + (high - low) / 2;

                if (list[mid] < n)
                {
                    low = mid + 1;
                }
                if (list[mid] > n)
                {
                    high = mid - 1;
                }
                if (list[mid] == n)
                {
                    break;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {FindUnmodified(numbers, number)} iterations");
            Console.WriteLine($"Binary search made {FindModified(numbers, number)} iterations");
        }
    }
}
