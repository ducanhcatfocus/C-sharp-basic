using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xay_dung_lop_Fan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, true, 10, "yellow");
            Fan fan2 = new Fan(2, false, 5, "blue");

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
            Console.ReadKey();

        }
    }
}
