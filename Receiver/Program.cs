﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Receiver
{
   class footfall
    {
        string[] date = new string[65];
        int[] countondate = new int[65];
        public void setdate(int index,string dateonindex)
        {
            date[index] = dateonindex;
        }
        public void setcountondate(int index,int countonindex)
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
            for (int i = startIndex; i < 7*startOfweak; i++)
                sum = sum + countondate[i];
            average = (double)sum / 7;
            return average;
        }
        public int getpeekinmonth(int startOfmonth)
        {
            int startIndex = 30*(startOfmonth-1);
            int max = countondate[startIndex];
            for (int i = startIndex+1; i < 30*startOfmonth; i++)
            {
                if (countondate[i] > max)
                    max = countondate[i];
            }
            return max;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            footfall obj = new footfall();
            string temp;
            int count = 0;
            while ((temp = Console.ReadLine()) != null)
            {
                var splitted = temp.Split(new[] { ' ' }, 2);
                obj.setdate(count,splitted[0]);
                obj.setcountondate(count,int.Parse(splitted[1]));
                 //Console.WriteLine(splitted[0]); 
                // Console.WriteLine(int.Parse(splitted[1]));
                count++;
            }

            double[] avgPerDay = new double[4];
            double[] avgPerWeak = new double[4];
            int[] peakPerMonth = new int[2];
            
            for (int i = 1; i <= 4; i++)
            {
                avgPerDay[i - 1] = obj.getaverageperday(i);
                avgPerWeak[i-1] = obj.getaverageperweak(i);
            }
            for(int i=1;i<=2;i++)
                peakPerMonth[i - 1] = obj.getpeekinmonth(i);
            Console.WriteLine("AVERAGE PER DAY for continuous 4 days are ");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(avgPerDay[i]);
            Console.WriteLine("average in continuous 4 weaks are :");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(avgPerWeak[i]);
            Console.WriteLine("peaks in continuous 2 months are :");
            for (int i = 0; i < 2; i++)
                Console.WriteLine(peakPerMonth[i]);
            

            Console.ReadLine();
            // string avgperweak = ans.ToString();
             //string maxinweak = ans1.ToString();
           /*  StringBuilder content = new StringBuilder();
             content.AppendLine("averageperDay,averageperWeak,peakinWeak");
            for(int i=0;i<4;i++)
            {
                content.Append(avgPerDay[i]);
                content.Append(avgPerWeak[i]);
            }
             //content.Append(avgperweak);
             //content.Append(maxinweak);
             string path = "c:\\csvfolder\\output.csv";
             File.WriteAllText(path, content.ToString());*/
            
        }
    }
}