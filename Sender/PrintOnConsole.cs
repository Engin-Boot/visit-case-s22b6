using System;
using System.Collections.Generic;


namespace Sender
{
    public class PrintOnConsole
    {
        int _countOfLoop;
        public void PrintingInfoOnConsole(List<string> lines)
        {
            for (int i = 1; i < lines.Count; i++)
            {
                Console.WriteLine(lines[i]);
                _countOfLoop++;
            }
            Console.ReadLine();
            
        }
        public int NumberOfRowsPrintingOnConsole()
        {
            return _countOfLoop;
        }
    }
}