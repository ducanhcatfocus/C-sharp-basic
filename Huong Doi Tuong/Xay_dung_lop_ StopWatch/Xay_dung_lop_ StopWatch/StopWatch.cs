using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xay_dung_lop__StopWatch
{
    internal class StopWatch
    {
        DateTime startTime;
        DateTime endTime;

        public StopWatch()
        {
            startTime =  DateTime.Now;
          
        }

        public DateTime StartTime { get => startTime; }
        public DateTime EndTime { get => endTime; }


        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public long GetElapsedTime()
        {
            return DateTime.Now.Ticks - startTime.Ticks;
        }


        public long SelectionSortTime(int[] arr, int n)
        {
            startTime = DateTime.Now;

            int i, j, min_idx;
            for (i = 0; i < n - 1; i++)
            {
                min_idx = i;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                }
                if (min_idx != i)
               
                (arr[min_idx], arr[i]) = (arr[i], arr[min_idx]);
            }
            endTime = DateTime.Now;
            return endTime.Ticks - startTime.Ticks;
        }
    }
}
