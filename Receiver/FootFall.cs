using System;
using System.Collections.Generic;
using System.Linq;

namespace Receiver
{
    public class FootFall
    {
        public Dictionary<string, List<string>> internalDictionary = new Dictionary<string, List<string>>();
        public void AddData(string key, string value)
        {
            if (this.internalDictionary.ContainsKey(key))
            {
                List<string> list = this.internalDictionary[key];
                if (list.Contains(value) == false)
                {
                    list.Add(value);
                }
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(value);
                this.internalDictionary.Add(key, list);
            }
        }
        

        public double GetAveragePerDay(string day)
        {
            double averageOfday;           
            averageOfday = internalDictionary[day].Count / 7;
            return averageOfday;
        }
        public List<double> GetAveragePerWeek()
        {
            int sum = 0;
            int k = 0;
            List<double> avg = new List<double>();
            List<int> countFoot = new List<int>();
            foreach (KeyValuePair<string, List<string>> kvp in internalDictionary)
            {
                List<string> c = internalDictionary[kvp.Key];
                k++;
                sum += c.Count;
                if (k == 7)
                {
                    k = 0;
                    countFoot.Add(sum);
                    sum = 0;
                }
            }
            avg = GetAvgCalcWeek(avg, countFoot,sum);
            
            return avg;
        }
        public List<int> GetPeekInMonth()
        {
            int peak;
            int k = 0;
            List<int> countFoot = new List<int>();
            List<int> peakList = new List<int>();
            List<int> peaks = new List<int>();
            foreach (KeyValuePair<string, List<string>> kvp in internalDictionary)
            {
                List<string> c = internalDictionary[kvp.Key];
                countFoot.Add(c.Count);
                k++;
                if (k == 30)
                {
                    k = 0;
                    peakList.Add(countFoot.Max());
                }
            }
            peak = GetCalcMonth(countFoot, peakList);
            
            peaks.Add(peak);
            return peaks;
        }
        public List<double> GetAvgCalcWeek(List<double> avg,List<int> countFoot,int sum)
        {
            if (internalDictionary.Count < 7)
            {
                avg.Add(sum / internalDictionary.Count);
            }
            else
            {
                for (int i = 0; i <= countFoot.Count / 7; i++)
                {
                    avg.Add(countFoot[i] / 7);
                }
            }
            return avg;
        }
        public int GetCalcMonth( List<int> countFoot, List<int> peakList)
        {
            int peak;
            if (internalDictionary.Count < 30)
            {
                peak = countFoot.Max();
            }
            else
            {
                peak = peakList[peakList.Count - 1];
            }
            return peak;
        }
    }
}
