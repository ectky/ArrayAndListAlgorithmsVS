using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obstacles = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            List<string> obstacle = new List<string>();

            int i = 0;

            while (true)
            {
                if (obstacles[i] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else
                {
                    obstacle = obstacles[i].Split('|').ToList();
                    if (obstacle[0] == "Bomb")
                    {
                        energy -= int.Parse(obstacle[1]);
                        obstacles.Remove(obstacles[i]);
                        i = 0;

                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                    }
                    else if (obstacle[0] == "Left")
                    {
                        int positions = int.Parse(obstacle[1]);
                        energy -= positions;
                        i = Math.Abs(i - positions) % obstacles.Count;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }
                        
                    }
                    else if (obstacle[0] == "Right")
                    {
                        int positions = int.Parse(obstacle[1]);
                        energy -= positions;
                        i = (i + positions) % obstacles.Count;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }
                    }


                    if (obstacles[obstacles.Count - 1] == "RabbitHole")
                    {
                        obstacles.Add($"Bomb|{energy}");
                    }
                    else
                    {
                        obstacles[obstacles.Count - 1] = $"Bomb|{energy}";
                    }
                }
            }

        }
    }
}
