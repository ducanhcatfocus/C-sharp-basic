using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_Hinh_Chu_Nhat
{
    internal class Rectangle
    {
        float width , height;

        public Rectangle()
        {

        }

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float GetArea()
        {
            return width * height;
        }

        public float GetPerimeter()
        {
            return 2* (width + height);
        }

        public string Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";
        }
    }
}
