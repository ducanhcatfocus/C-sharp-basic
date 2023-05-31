using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xay_dung_lop_Fan
{
    public class Fan
    {
        const int slow = 1, medium = 2, fast = 3;
        int speed;
        bool on;
        double radius;
        string color;

        public Fan() {
            speed = slow;
            on = false;
            radius = 5;
            color = "blue";
        }


        public Fan(int speed = slow, bool on = false, double radius = 5, string color = "blue")
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }


        public override string ToString()
        {
            string str = on ? "Fan is on" : "Fan is off";
            return "Speed: " + speed + "\n" + "Color: " + color + "\n" + "Radius: " + radius + "\n" + str;
        }
    }
}
