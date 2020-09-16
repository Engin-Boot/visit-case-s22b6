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
                List<string> infoFootfall = new List<string>();
                string Line;
                while ((Line = source.ReadLine()) != null)
                {
                    //string[] line = source.ReadLine().Split(',');
                    // lines.Add(line);
                    infoFootfall.Add(Line);
                }
                PrintOnConsole printOnConsole = new PrintOnConsole();
                printOnConsole.PrintingInfoOnConsole(infoFootfall);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}