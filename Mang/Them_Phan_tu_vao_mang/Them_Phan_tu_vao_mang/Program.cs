using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Them_Phan_tu_vao_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool isValid = true;
            while (true)
            {
                Console.WriteLine("Enter value: ");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter index: ");
                int index = int.Parse(Console.ReadLine());
                if (index < 0 || index > arr.Length - 1)
                {
                    Console.WriteLine("Index invalid!");
                    isValid = false;
                  
                }

                if (isValid)
                {
                    for (int i = arr.Length - 1; i > index; i--)
                    {
                        arr[i] = arr[i - 1];
                    }

                    arr[index] = value;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ", ");
                }

                Console.ReadKey();
            }

       
        }
    }
}
