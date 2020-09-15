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
                var splitted = temp.Split(new[] { ' ' }, 2);
                obj.Setdate(count,splitted[0]);
                obj.Setcountondate(count,int.Parse(splitted[1]));
                 //Console.WriteLine(splitted[0]); 
                // Console.WriteLine(int.Parse(splitted[1]));
                count++;
            }

            double[] avgPerDay = new double[63];
            double[] avgPerWeak = new double[8];
            int[] peakPerMonth = new int[2];

            CheckGetDay(avgPerDay,obj);
            CheckGetWeek(avgPerWeak, obj);
            CheckGetMonthly(peakPerMonth, obj);
            /* Console.WriteLine("AVERAGE PER DAY for continuous 63 days are ");
             for (int i = 0; i < 63; i++)
                 Console.WriteLine(avgPerDay[i]);
             Console.WriteLine("average in continuous 8 weaks are :");
             for (int i = 0; i < 8; i++)
                 Console.WriteLine(avgPerWeak[i]);
             Console.WriteLine("peaks in continuous 2 months are :");
             for (int i = 0; i < 2; i++)
                 Console.WriteLine(peakPerMonth[i]);*/

            Console.WriteLine("CSV output file is generated");
            Console.ReadLine();
            WriteToCsv csv = new WriteToCsv();
            csv.WriteResultToCsv(avgPerDay,avgPerWeak,peakPerMonth);

            
            
        }
        private static void CheckGetDay(double[] avgPerDay, FootFall obj)
        {
            for (int i = 1; i <= 63; i++)
            {
                avgPerDay[i - 1] = obj.Getaverageperday(i);
            }
         }
        private static void CheckGetWeek(double[] avgPerWeak, FootFall obj)
        {
            for (int i = 1; i <= 8; i++)
            {
                avgPerWeak[i - 1] = obj.Getaverageperweak(i);
            }
        }
        private static void CheckGetMonthly(int[] peakPerMonth, FootFall obj)
        {
            for (int i = 1; i <= 2; i++)
                peakPerMonth[i - 1] = obj.Getpeekinmonth(i);
        }
    }
}
