using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {   {"*", ".", ".", "."},
      {".", ".", ".", "."},
      {".", "*", ".", "."},
      {".", ".", ".", "."} };
            int MAP_WIDTH = map.GetLength(1);
            int MAP_HEIGHT = map.GetLength(0);
            string[,] newMap = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int j = 0; j < MAP_HEIGHT; j++)
            {
                for (int i = 0; i < MAP_WIDTH; i++)
                {
                    if (map[j, i] == "*")
                    {
                        newMap[j, i] = "*";
                     



                    }
                    else
                    {
                     
                        int mineAround = 0;

                    
                
                        if (i < MAP_WIDTH - 1 && map[j, i + 1] == "*")
                        {
                            mineAround++;
                        }

                        if (i > 0 && map[j, i - 1] == "*")
                        {
                            mineAround++;

                        }

                        if (j > 0 && map[j - 1, i] == "*")
                        {
                            mineAround++;

                        }
                        if (j < MAP_HEIGHT - 1 && map[j + 1, i] == "*")
                        {
                            mineAround++;

                        }




                        newMap[j, i] = mineAround.ToString();


                    };
                }
            }

            for (int j = 0; j < MAP_HEIGHT; j++)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < MAP_WIDTH; i++)
                {
                    Console.Write(newMap[j, i]);
                }
           
            }

         

            Console.ReadKey();
        }
    }
}
