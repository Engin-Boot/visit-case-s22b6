using System;

namespace Receiver
{
    class FootFall
    {
        readonly string[] date = new string[65];
        readonly int[] countOnDate = new int[65];
        public void Setdate(int index, string dateOnIndex)
        {
            date[index] = dateOnIndex;
        }
        public void Setcountondate(int index, int counOnIndex)
        {
            countOnDate[index] = counOnIndex;
        }
        public double GetAveragePerDay(int startOfDay)
        {
            double averageOfday = 0.0;
            averageOfday = (double)countOnDate[startOfDay - 1] / 24;
            return averageOfday;
        }
        public double GetAveragePerWeek(int startOfWeek)
        {
            int sum = 0;
            double average = 0.0;
            int startIndex = 7 * (startOfWeek - 1);
            for (int i = startIndex; i < 7 * startOfWeek; i++)
                sum = sum + countOnDate[i];
            average = (double)sum / 7;
            return average;
        }
        public int GetPeekInMonth(int startOfmonth)
        {
            int startIndex = 30 * (startOfmonth - 1);
            int max = countOnDate[startIndex];
            for (int i = startIndex + 1; i < 30 * startOfmonth; i++)
            {
                if (countOnDate[i] > max)
                    max = countOnDate[i];
            }
            return max;
        }
    }
}
