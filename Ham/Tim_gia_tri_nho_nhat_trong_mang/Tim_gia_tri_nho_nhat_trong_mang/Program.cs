using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_gia_tri_nho_nhat_trong_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int FindSmallestNum(int[] nums)
        {
            int temp = nums[0];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < temp)
                {
                    temp = nums[i];
                    index = i;

                }
            }
            return index;
        }
    }
}
