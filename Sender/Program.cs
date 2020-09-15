using System;
using System.Collections.Generic;
using System.IO;
namespace Sender
{
    abstract class Program
    {
        static void Main()
        {
            try
            {
                string filePath = @"c:\csvfolder\casestudy.csv";
                StreamReader source = new StreamReader(filePath);
                var lines = new List<string[]>();
                while (!source.EndOfStream)
                {
                   
                    lines.Add(source.ReadLine().Split(','));
                }
                PrintOnConsole printOnConsole = new PrintOnConsole();
                printOnConsole.PrintingInfoOnConsole(lines);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}