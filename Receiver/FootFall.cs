using System;

namespace Receiver
{
    class FootFall
    {
        readonly string[] date = new string[65];
        readonly int[] countondate = new int[65];
        public void Setdate(int index, string dateonindex)
        {
            date[index] = dateonindex;
        }
        public void Setcountondate(int index, int countonindex)
        {
            countondate[index] = countonindex;
        }
        public double Getaverageperday(int startofday)
        {
            double averageOfday = 0.0;
            averageOfday = (double)countondate[startofday - 1] / 24;
            return averageOfday;
        }
        public double Getaverageperweak(int startOfweak)
        {
            int sum = 0;
            double average = 0.0;
            int startIndex = 7 * (startOfweak - 1);
            for (int i = startIndex; i < 7 * startOfweak; i++)
                sum = sum + countondate[i];
            average = (double)sum / 7;
            return average;
        }
        public int Getpeekinmonth(int startOfmonth)
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
