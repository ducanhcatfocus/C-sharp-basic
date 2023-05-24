using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_gia_tri_lon_nhat_trong_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size;
            int[] arr;
            Random random = new Random();

            do
            {
                Console.WriteLine("Enter array size: ");
                size = int.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size too big");
            }while (size > 20);

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {

                arr[i] = random.Next(0, 100);
                Console.WriteLine(arr[i]);

            }

            int gtln = arr[0];

            for (int i = 1;i < arr.Length; i++)
            {
                if (arr[i] > gtln)  gtln = arr[i];
            }

            Console.WriteLine("Gia tri lon nhat: " + gtln);

            Console.ReadKey();  
        }
    }
}
