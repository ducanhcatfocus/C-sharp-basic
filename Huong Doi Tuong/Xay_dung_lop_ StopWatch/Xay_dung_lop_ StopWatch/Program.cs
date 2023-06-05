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

            int n = 100000;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0,1000);
                Console.WriteLine(arr[i]);
            }
            sw.Start();
            sw.SelectionSortTime(arr, n);
            sw.Stop();
            Console.WriteLine("Times: " + sw.GetElapsedTime());
            Console.ReadKey();
        }
    }
}
