using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> list = new List<int>();
            int removed = 0;

            while (input != "stop")
            {
                try
                {
                    int num = int.Parse(input);
                    list.Insert(0, num);
                }
                catch (Exception)
                {
                    if (list.Count > 0)
                    {
                        double average = GetAverage(list);
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] <= average)
                            {
                                removed = list[i];
                                list.Remove(removed);
                                Console.WriteLine("shot {0}", removed);
                                list = Decrement(list);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", removed);
                        return;
                    }
                }
                input = Console.ReadLine();
            }

            if (list.Count > 0)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("you shot them all. last one was {0}", removed);
            }
        }

        static List<int> Decrement(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i]--;
            }
            return list;
        }

        static double GetAverage(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum / list.Count;
        }
    }
}
