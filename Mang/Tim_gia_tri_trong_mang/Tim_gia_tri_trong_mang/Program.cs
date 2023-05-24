using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_gia_tri_trong_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            bool isExist = false;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].ToLower() == name.ToLower())
                {
                    Console.WriteLine("Position of the students in the list " + name + " is: " + (i + 1));
                    isExist = true;
                    break;
                };
               
            }
            if (!isExist)
            {
                Console.WriteLine("Not found " + name + " in the list.");

            }
            Console.ReadKey();
        }
    }
}
