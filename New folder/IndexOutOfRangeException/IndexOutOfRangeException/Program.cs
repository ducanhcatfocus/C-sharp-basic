using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> list = new List<char>();
                list.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                //int value = list[6];
                int value1 = list[-1];



            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();

        }
    }
}
