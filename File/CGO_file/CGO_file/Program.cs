using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_file
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;


                    while ((line = sr.ReadLine()) != "")
                    {
                        list.Add(int.Parse(line));

                    }
                }


                using (StreamWriter wt = new StreamWriter("Output.txt"))
                {
                    for (int j = 0; j < list.Count; j = j + 2)
                    {

                        wt.WriteLine(list[j] * list[j + 1]);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           

            string readText = File.ReadAllText("Output.txt");
            Console.WriteLine(readText);
            Console.ReadKey();
        }
    }
}
