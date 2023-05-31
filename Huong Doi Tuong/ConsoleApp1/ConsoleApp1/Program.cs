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
            Person p = new Person("NDA", 1998, 1);
            p.Xuat();
            p.namsinh = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
