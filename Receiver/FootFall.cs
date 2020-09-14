using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class FootFall
    {
        string[] date = new string[65];
        int[] countondate = new int[65];
        public void setdate(int index, string dateonindex)
        {
            date[index] = dateonindex;
        }
        public void setcountondate(int index, int countonindex)
        {
            countondate[index] = countonindex;
        }
        public double getaverageperday(int startofday)
        {
            double averageOfday;
            averageOfday = (double)countondate[startofday - 1] / 24;
            return averageOfday;
        }
        public double getaverageperweak(int startOfweak)
        {
            int sum = 0;
            double average;
            int startIndex = 7 * (startOfweak - 1);
            for (int i = startIndex; i < 7 * startOfweak; i++)
                sum = sum + countondate[i];
            average = (double)sum / 7;
            return average;
        }
        public int getpeekinmonth(int startOfmonth)
        {
            int startIndex = 30 * (startOfmonth - 1);
            int max = countondate[startIndex];
            for (int i = startIndex + 1; i < 30 * startOfmonth; i++)
            {
                if (countondate[i] > max)
                    max = countondate[i];
            }
            return max;
        }
    }
}
