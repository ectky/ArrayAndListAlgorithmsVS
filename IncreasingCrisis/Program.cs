using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            int i = 0;

            for (int m = 0; m < n; m++)
            {
                List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                if (result.Count > 0)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        for (i = 0; i < result.Count - 1; i++)
                        {
                            if (list[j] >= result[i] && list[j] <= result[i + 1])
                            {
                                result.Insert(i + 1, list[j]);
                                break;
                            }
                            else if (list[j] >= result[i + 1] && i + 1 == result.Count - 1)
                            {
                                result.Add(list[j]);
                                break;
                            }
                        }
                        if (j < list.Count - 1 && list[j] > list[j + 1])
                        {
                            while (i + 2 < result.Count)
                            {
                                result.RemoveAt(i + 2);
                            }
                            break;
                        }
                    }
                }
                else
                {
                    result = list;
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
