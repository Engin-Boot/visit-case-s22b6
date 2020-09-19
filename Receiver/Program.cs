using System;
using System.Collections.Generic;

namespace Receiver
{
   
     abstract class Program
     {
        static void Main()
        {
            FootFall footFall = new FootFall();
            string temp;
            while ((temp = Console.ReadLine()) != null)
            {
                var splitted = temp.Split(new[] { ',' }, 2);
                footFall.AddData(splitted[0], splitted[1]);
            }
            //footFall.Print();

            //List<double> avgPerDay = new List<double>();


            List<double> avgPerDay = footFall.CheckGetDay();
            List<double> avgWeek = footFall.GetAveragePerWeek();
            List<int> peakPerMonth= footFall.GetPeekInMonth();
           
            Console.WriteLine("CSV output file is generated");
            Console.ReadLine();
            WriteToCsv csv = new WriteToCsv();
            csv.WriteResultToCsv(avgPerDay, avgWeek, peakPerMonth);

        }
        
       
    }
}
