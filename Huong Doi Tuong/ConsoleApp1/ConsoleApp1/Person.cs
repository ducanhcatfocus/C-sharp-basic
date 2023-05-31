using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string hoten;
        public int namsinh;
        public int gioitinh;

        public Person(string hoten, int namsinh, int gioitinh)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
        }

        public string Hoten { get => hoten; set => hoten = value; }

        public int Gioitinh { get => gioitinh; }

        public void Xuat()
        {
            Console.WriteLine(hoten + " " + namsinh);
        }
    }
}
