﻿using System;
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
                string filePath = @"c:\csvfolder\casestudy1.csv";
                StreamReader source = new StreamReader(filePath);
                List<string> infoFootfall = new List<string>();
                string line;
                while ((line = source.ReadLine()) != null)
                {
                    infoFootfall.Add(line);
                }
                PrintOnConsole printOnConsole = new PrintOnConsole();
                printOnConsole.PrintingInfoOnConsole(infoFootfall);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}