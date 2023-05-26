using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xoa_phan_tu_khoi_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3,7,8,9,0,0 };
            Console.WriteLine("Nhap so can xoa: ");
            int number = int.Parse(Console.ReadLine());
            bool isExist = false;
            int index;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    isExist = true;
                    for (int j = i; j<arr.Length -1; j++)
                    {
                        arr[j] = arr[j +1];
                    }
                    break;
                }
                  
            }

            if (!isExist)
            {
                Console.WriteLine("So khong ton tai");
            }
            else
            {
                for (int i = 0;i < arr.Length;i++)
                {
                    Console.WriteLine(arr[i]);

                }
            }

            Console.ReadKey();
        }
    }
}
