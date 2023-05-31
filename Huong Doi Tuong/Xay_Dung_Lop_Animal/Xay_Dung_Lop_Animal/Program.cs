using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xay_Dung_Lop_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("3kg", "50", "MEO");
            cat.PrintInfo();


            Cat cat2 = new Cat("5kg", "70", "CATT");
            cat2.PrintInfo();
            Console.ReadKey();


        }
    }
}
