using System;

namespace Receiver
{
   
     abstract class Program
    {
        static void Main()
        {
            FootFall obj = new FootFall();
            string temp;
            int count = 0;
            while ((temp = Console.ReadLine()) != null)
            {
                var splitted = temp.Split(new[] { ',' }, 2);
                obj.Setdate(count,splitted[0]);
                obj.Setcountondate(count,int.Parse(splitted[1]));
                count++;
            }

            double[] avgPerDay = new double[63];
            double[] avgPerWeak = new double[8];
            int[] peakPerMonth = new int[2];

            CheckGetDay(avgPerDay,obj);
            CheckGetWeek(avgPerWeak, obj);
            CheckGetMonthly(peakPerMonth, obj);
           
            Console.WriteLine("CSV output file is generated");
            Console.ReadLine();
            WriteToCsv csv = new WriteToCsv();
            csv.WriteResultToCsv(avgPerDay,avgPerWeak,peakPerMonth);

        }
        private static void CheckGetDay(double[] avgPerDay, FootFall foot)
        {
            for (int i = 1; i <= 63; i++)
            {
                avgPerDay[i - 1] = foot.GetAveragePerDay(i);
            }
        }
        private static void CheckGetWeek(double[] avgPerWeak, FootFall foot)
        {
            for (int i = 1; i <= 8; i++)
            {
                avgPerWeak[i - 1] = foot.GetAveragePerWeek(i);
            }
        }
        private static void CheckGetMonthly(int[] peakPerMonth, FootFall foot)
        {
            for (int i = 1; i <= 2; i++)
                peakPerMonth[i - 1] = foot.GetPeekInMonth(i);
        }
    }
}
