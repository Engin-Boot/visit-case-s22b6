using System;
using System.Collections.Generic;

namespace Receiver
{
   
     abstract class Program
    {
        static void Main()
        {
            FootFall obj = new FootFall();
            string temp;
           // int count = 0;
            while ((temp = Console.ReadLine()) != null)
            {
                var splitted = temp.Split(new[] { ',' }, 2);
                obj.Setdate(splitted[0]);
                obj.Setcountondate(int.Parse(splitted[1]));
                //count++;
            }

            List<double> avgPerDay = new List<double>();
            List<double> avgPerWeak = new List<double>();
            List<int> peakPerMonth = new List<int>();

            CheckGetDay(avgPerDay,obj);
            CheckGetWeek(avgPerWeak, obj);
            CheckGetMonthly(peakPerMonth, obj);
           
            Console.WriteLine("CSV output file is generated");
            Console.ReadLine();
            WriteToCsv csv = new WriteToCsv();
            csv.WriteResultToCsv(avgPerDay,avgPerWeak,peakPerMonth, obj);

        }
        private static void CheckGetDay(List<double> avgPerDay, FootFall foot)
        {
            for (int i = 1; i <= foot._date.Count; i++)
            {
                avgPerDay.Add(foot.GetAveragePerDay(i));
            }
        }
        private static void CheckGetWeek(List<double> avgPerWeak, FootFall foot)
        {
            for (int i = 1; i <= (int)foot._date.Count/7; i++)
            {
                avgPerWeak.Add(foot.GetAveragePerWeek(i));
            }
        }
        private static void CheckGetMonthly(List<int> peakPerMonth, FootFall foot)
        {
            for (int i = 1; i <= (int)foot._date.Count/30; i++)
                peakPerMonth.Add(foot.GetPeekInMonth(i));
        }
    }
}
