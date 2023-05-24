using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_tong_phan_tu_trong_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };


            int sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.Write("tong: " + sum);
            Console.ReadKey();
        }
    }
}
