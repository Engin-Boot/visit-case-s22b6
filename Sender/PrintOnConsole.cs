using System;
using System.Collections.Generic;


namespace Sender
{
    class PrintOnConsole
    {
        int _countOfLoop = 0;
        public void PrintingInfoOnConsole(List<string[]> lines)
        {

            for (int rowNumber = 1; rowNumber < lines.Count; rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < lines[rowNumber].Length; columnNumber++)
                {
                    Console.Write(lines[rowNumber][columnNumber]);
                    Console.Write(" ");
                }
                _countOfLoop++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public int NumberOfRowsPrintingOnConsole()
        {
            return _countOfLoop;
        }
    }
}