using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem_so_lan_ky_tu_trong_chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot chuoi: ");
            string str = Console.ReadLine();
            Console.WriteLine("Nhap mot ky tu: ");
            char ch = char.Parse( Console.ReadLine());

            int count = 0;


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch) { count++; }
            }

            Console.WriteLine("Ky tu: " + ch + " xuat hien " + count + " lan");
            Console.ReadKey();
        }
    }
}
