using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tenLong();

            int[] long3 = { 23, 5, 2008, 12,32,45,56,76,878,9,54,3,34,56,78,89,90,34 };

            int tong = long3[0];
            for (int i = 1; i < long3.Length; i++)
            {
          
                tong = tong + long3[i];
            }
            Console.WriteLine(tong);


            Console.ReadKey();
        }

        private static void tenLong()
        {
            int long1 = 9;


            string long2 = "Long";


            Console.WriteLine("Nhap ten cua ban: ");
            long2 = Console.ReadLine();
            Console.WriteLine(long2);
        }
    }
}
