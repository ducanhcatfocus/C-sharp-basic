using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xay_dung_lop__StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch sw = new StopWatch();
            Random rnd = new Random();

            int[] arr = new int[10000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,1000);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Times: " + sw.SelectionSortTime(arr, 10000));
            Console.ReadKey();
        }
    }
}
