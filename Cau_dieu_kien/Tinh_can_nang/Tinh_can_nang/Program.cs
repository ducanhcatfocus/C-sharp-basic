using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_can_nang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap can nang: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao: ");
            float height = float.Parse(Console.ReadLine());
            float bmi = weight / height;

            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
                Console.ReadKey();

                return;
            }

            if(bmi< 25.0)
            {
                Console.WriteLine("Normal");
                Console.ReadKey();

                return;
            }
            if(bmi< 30.0)
            {
                Console.WriteLine("Overweight");
                Console.ReadKey();

                return;
            }
            Console.WriteLine("Obese");
            Console.ReadKey();
        }
    }
}
