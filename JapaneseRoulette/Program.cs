using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            string[] values = Console.ReadLine().Split(' ');
            int[] arr = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                arr[i] = int.Parse(values[i]);
                if (arr[i] == 1)
                {
                    position = i;
                }
            }
           
            string[] players = Console.ReadLine().Split(' ');
            for (int i = 0; i < players.Length; i++)
            {

                string direction = players[i].Split(',').ToArray()[1];
                int power = int.Parse(players[i].Split(',').ToArray()[0]);
                if (direction == "Right")
                {
                    position = (position + power) % arr.Length;
                }
                else
                {
                    if (position - power < 0)
                    {
                        position = arr.Length - (Math.Abs(position - power) % arr.Length);
                    }
                    else
                    {
                        position -= power;
                    }
                }

                if (position == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }

                position = position + 1 == arr.Length ? 0 : position + 1;
            }

            Console.WriteLine("Everybody got lucky!");
        }
    }
}
