using System.Collections.Generic;

namespace Receiver
{
    class FootFall
    {
        readonly public List<string> _date = new List<string>();
        readonly public List<int> _countOnDate = new List<int>();
        public void Setdate( string dateOnIndex)
        {
            _date.Add(dateOnIndex);
        }
        public void Setcountondate(int counOnIndex)
        {
            _countOnDate.Add(counOnIndex);
        }
        public double GetAveragePerDay(int startOfDay)
        {
            double averageOfday = (double)_countOnDate[startOfDay - 1] / 24;
            return averageOfday;
        }
        public double GetAveragePerWeek(int startOfWeek)
        {
            int sum = 0;
            int startIndex = 7 * (startOfWeek - 1);
            for (int i = startIndex; i < 7 * startOfWeek; i++)
                sum += _countOnDate[i];
            double average = (double)sum / 7;
            return average;
        }
        public int GetPeekInMonth(int startOfmonth)
        {
            int startIndex = 30 * (startOfmonth - 1);
            int max = _countOnDate[startIndex];
            for (int i = startIndex + 1; i < 30 * startOfmonth; i++)
            {
                if (_countOnDate[i] > max)
                    max = _countOnDate[i];
            }
            return max;
        }
    }
}
