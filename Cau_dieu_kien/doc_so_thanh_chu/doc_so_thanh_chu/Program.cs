using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doc_so_thanh_chu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so toi da 3 chu so: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 999 || number <0 ) {
                Console.WriteLine("out of ability");
                Console.ReadKey();
                return;
            }

            string donVi = "";

            string hangChuc = "";
            string hangTram = "";

            if(number < 10)
            {
                switch (number)
                {
                    case 0: donVi = "rezo"; break;
                    case 1: donVi = "one"; break;
                    case 2: donVi = "two"; break;
                    case 3: donVi = "three"; break;
                    case 4: donVi = "four"; break;
                    case 5: donVi = "five"; break;
                    case 6: donVi = "six"; break;
                    case 7: donVi = "seven"; break;
                    case 8: donVi = "eight"; break;
                    case 9: donVi = "nine"; break;

                }
                Console.WriteLine(donVi);
                Console.ReadKey();
                return;
            }

            if(number < 20)
            {
                donVi = NewMethod(number, donVi);
                Console.WriteLine(donVi);
                Console.ReadKey();
                return;
            }
            if (number < 100)
            {
                switch (number / 10)
                {
                    case 2: hangChuc = "twenty"; break;
                    case 3: hangChuc = "thirty"; break;
                    case 4: hangChuc = "fourty"; break;
                    case 5: hangChuc = "fifty"; break;
                    case 6: hangChuc = "sixty"; break;
                    case 7: hangChuc = "seventy"; break;
                    case 8: hangChuc = "eighty"; break;
                    case 9: hangChuc = "ninety"; break;
                }
                switch (number % 10)
                {
                    case 0: donVi = "rezo"; break;
                    case 1: donVi = "one"; break;
                    case 2: donVi = "two"; break;
                    case 3: donVi = "three"; break;
                    case 4: donVi = "four"; break;
                    case 5: donVi = "five"; break;
                    case 6: donVi = "six"; break;
                    case 7: donVi = "seven"; break;
                    case 8: donVi = "eight"; break;
                    case 9: donVi = "nine"; break;

                }
                Console.WriteLine(hangChuc + " " + donVi);
                Console.ReadKey();
                return;
            }

            if (number <= 999)
            {
                switch (number / 100)
                {
                    case 2: hangChuc = "twenty"; break;
                    case 3: hangChuc = "thirty"; break;
                    case 4: hangChuc = "fourty"; break;
                    case 5: hangChuc = "fifty"; break;
                    case 6: hangChuc = "sixty"; break;
                    case 7: hangChuc = "seventy"; break;
                    case 8: hangChuc = "eighty"; break;
                    case 9: hangChuc = "ninety"; break;
                }
                switch (number / 100)
                {
                    case 1: hangTram = "one"; break;
                    case 2: hangTram = "two"; break;
                    case 3: hangTram = "three"; break;
                    case 4: hangTram = "four"; break;
                    case 5: hangTram = "five"; break;
                    case 6: hangTram = "six"; break;
                    case 7: hangTram = "seven"; break;
                    case 8: hangTram = "eight"; break;
                    case 9: hangTram = "nine"; break;

                }
                Console.WriteLine(hangTram + " " + "hundred" + " " + hangChuc + " " + donVi);
                Console.ReadKey();
                return;
            }

        }

        private static string NewMethod(int number, string donVi)
        {
            switch (number)
            {
                case 10: donVi = "ten"; break;
                case 11: donVi = "eleven"; break;
                case 12: donVi = "twelve"; break;
                case 13: donVi = "thirteen"; break;
                case 14: donVi = "fourteen"; break;
                case 15: donVi = "fifteen"; break;
                case 16: donVi = "sixteen"; break;
                case 17: donVi = "seventeen"; break;
                case 18: donVi = "eighteen"; break;
                case 19: donVi = "nineteen"; break;
            }

            return donVi;
        }
    }
}
