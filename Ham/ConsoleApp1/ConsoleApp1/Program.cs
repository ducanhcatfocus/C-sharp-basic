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
            int a, b;
            Console.Write("Nhap so a: ");
             a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine());

            DoiCho(ref a, ref b);
            Console.Write(a + " " + b);

            Console.ReadKey();

        }

        private static void ham(out int a, out int b, out int c)
        {
            a = 1;
            b = 2;
            c = 3;
        }


        private static void DoiCho(ref int so1, ref int so2)
        {
            (so1, so2) = (so2, so1);
        }


    }
}
