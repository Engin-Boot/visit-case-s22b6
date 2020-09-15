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
                StreamReader source = new StreamReader(filePath);
                var lines = new List<string[]>();
                while (!source.EndOfStream)
                {
                    //string[] line= null;
                    if (source.ReadLine().Split(',') != null) {
                    string[] line = source.ReadLine().Split(',');
                    lines.Add(line);
                }
                    
                    
                }
                PrintOnConsole printOnConsole = new PrintOnConsole();
                printOnConsole.PrintingInfoOnConsole(lines);
                      
        }
    }
}