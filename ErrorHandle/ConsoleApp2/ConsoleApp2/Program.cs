using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine((float) a/b);
            Console.ReadKey();  
        }


        
    }
}
