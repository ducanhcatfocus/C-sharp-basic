using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_Hinh_Chu_Nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the width: ");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            float height = float.Parse(Console.ReadLine());

            Rectangle rec = new Rectangle(width, height);
            Console.WriteLine("Your Rectangle \n" + rec.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rec.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rec.GetArea());

            Console.ReadKey();
        }
    }
}
