﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var reader = new StreamReader(@"c:\csvfolder\casestudy.csv"))
            {
                 List<string> listA = new List<string>();
                 List<string> listB = new List<string>();

 

             while (!reader.EndOfStream)
                 {
                     var line = reader.ReadLine();
                     var values = line.Split(',');

 

                     listA.Add(values[0]);
                 listB.Add(values[1]);

 

             }
             for(int i = 0; i < listA.Count; i++)
                 Console.WriteLine(listA[i]);
             for (int i = 0; i < listB.Count; i++)
                 Console.WriteLine(listB[i]);
            Console.WriteLine(Row);
            Console.WriteLine(lines[0].Length);
            Console.WriteLine(lines.Count);
            Console.WriteLine(lines[0][5]);
                */
            string filePath = @"c:\csvfolder\casestudy1.csv";
            StreamReader sr = new StreamReader(filePath);
            var lines = new List<string[]>();
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] Line = sr.ReadLine().Split(',');
                lines.Add(Line);
                Row++;
            }
            // Row Number 0 is fixed for name of columns
            //Console.WriteLine("total no of data rows are " + Row);
            PrintOnConsole obj = new PrintOnConsole();
            obj.printingInfoOnConsole(lines);
        }
    }
}