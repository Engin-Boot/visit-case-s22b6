using System;
using System.Collections.Generic;
using System.IO;
namespace Sender
{
    abstract class Program
    {
        static void Main()
        {
            string filePath = @"c:\csvfolder\casestudy.csv";
            StreamReader sr = new StreamReader(filePath);
            var lines = new List<string[]>();
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');
                lines.Add(line);
            }
            PrintOnConsole printOnConsole = new PrintOnConsole();
            printOnConsole.PrintingInfoOnConsole(lines);
        }
    }
}