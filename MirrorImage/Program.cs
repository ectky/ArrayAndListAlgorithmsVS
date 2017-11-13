using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            string text = Console.ReadLine();

            while (text != "Print")
            {
                int index = int.Parse(text);
                list = ReverseList(list, index);
                text = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", list));
        }

        private static List<string> ReverseList(List<string> list, int index)
        {
            for (int i = 0; i < index / 2; i++)
            {
                string helper = list[i];
                list[i] = list[index - 1 - i];
                list[index - 1 - i] = helper;

            }

            int end = (list.Count - index) / 2; int j = 0;
            for (int i = index + 1; i <= index + end; i++)
            {
                string helper = list[i];
                list[i] = list[list.Count - 1 - j];
                list[list.Count - 1 - j] = helper;
                j++;
            }

            return list;
        }
    }
}
