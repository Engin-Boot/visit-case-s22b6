using System;
using System.Collections.Generic;


namespace Sender
{
    class PrintOnConsole
    {
        int _countOfLoop;
        public void PrintingInfoOnConsole(List<string> lines)
        {
            //_countOfLoop = 0;
            /* for (int rowNumber = 1; rowNumber < lines.Count; rowNumber++)
             {
                 for (int columnNumber = 0; columnNumber < lines[rowNumber].Length; columnNumber++)
                 {
                     Console.Write(lines[rowNumber][columnNumber]);
                     Console.Write(" ");
                 }
                 _countOfLoop++;
                 Console.WriteLine();
             }*/
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