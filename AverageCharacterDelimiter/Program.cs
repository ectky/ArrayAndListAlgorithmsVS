using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            int count = 0; int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    count++;
                    sum += (int)list[i][j];
                }
            }

            string delimiter = "";
            delimiter += (char)((int)(sum/count));
            delimiter = delimiter.ToUpper();
            Console.WriteLine(string.Join(delimiter, list));
        }
    }
}
