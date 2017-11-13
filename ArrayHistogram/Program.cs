using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> words = new List<string>();
            List<int> count = new List<int>();
            int index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (!words.Contains(list[i]))
                {
                    words.Add(list[i]);
                    count.Add(1);
                }
                else
                {
                    index = words.IndexOf(list[i]);
                    count[index]++;
                }
            }

            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < count.Count - 1; i++)
                {
                    if (count[i] < count[i + 1])
                    {
                        int helper = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = helper;
                        string helper2 = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = helper2;
                        swapped = true;
                    }
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (double)count[i] / list.Count * 100;
                Console.WriteLine($"{words[i]} -> {count[i]} times ({percentage:F2}%)");
            }
        }
    }
}
