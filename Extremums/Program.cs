using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            string minOrMax = Console.ReadLine();

            for (int i = 0; i < list.Count; i++)
            {
                int number = 0;

                switch (minOrMax)
                {
                    case "Min":
                        number = FindMinRotation(list[i]); break;
                    case "Max":
                        number = FindMaxRotation(list[i]); break;
                }

                result.Add(number);
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(result.Sum());
        }

        private static int FindMaxRotation(int number)
        {
            List<int> result = new List<int>();
            string text = number.ToString();

            for (int i = 0; i < text.Length; i++)
            {
                string middle = text.Substring(1, text.Length - 1);
                string newString = middle + text[0];
                text = newString;
                result.Add(int.Parse(newString));
            }

            return result.Max();
        }

        private static int FindMinRotation(int number)
        {
            List<int> result = new List<int>();
            string text = number.ToString();

            for (int i = 0; i < text.Length; i++)
            {
                string middle = text.Substring(1, text.Length - 1);
                string newString = middle + text[0];
                text = newString;
                result.Add(int.Parse(newString));
            }

            return result.Min();
        }
    }
}
