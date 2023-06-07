using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doi_tuong_hinh_hoc
{
    public class Shape
    {
        string color;
        bool filled;


        public Shape()
        {
            this.color = "green";
            this.filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public override string ToString()
        {
            return "A Shape with color of " + Color +  " and" + (Filled ? "filled" : "not filled");
        }
    }

    public class Circle: Shape
    {
        double radius = 1.0;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
          
        }

        public Circle(string color, bool filled, double radius):base(color, filled)
        {
            this.radius=radius;
        }

        public double Radius { get => radius; set => radius = value; }


        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return "A Circle with radius= " + Radius + ", which is a subclass of  " + base.ToString();
        }
    }


    public class Rectangle: Shape
    {
        double width;
        double length;

        public Rectangle()
        {
            this.width = 1.0;
            this.length =1.0;
        }

        public double GetArea()
        {
            return width * length;
        }

        public double GetPerimeter()
        {
            return 2 * (width+length);
        }

        public virtual double Width { get => width; set => width = value; }
        public virtual double Length { get => length; set => length = value; }

        public override string ToString()
        {
            return "A Rectangle with width= " + Width + " and length= " + Length +", which is a subclass of " + base.ToString();
        }
    }


    public class Square: Rectangle
    {

        double side;
        public Square() { }

        public Square(double side):base()
        {
            Width = 1.0;
           Length = 1.0;
        }

        public void SetSide(double side)

        {

            Width = side;

            Length = side;

        }

  


        public double Side { get => side; set => side = value; }
        public override string ToString() {

            return "A Square with side ="

                    + Side

                    + ", which is a subclass of "

                    +base.ToString();

        }

    }
}
