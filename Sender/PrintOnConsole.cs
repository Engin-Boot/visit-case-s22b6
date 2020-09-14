using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{   
    class PrintOnConsole
    {
        public void printingInfoOnConsole(List<string[]> lines)
        {
            for (int rownumber = 1; rownumber < lines.Count; rownumber++)
            {
                for (int columnnumber = 0; columnnumber < lines[rownumber].Length; columnnumber++)
                {
                    Console.Write(lines[rownumber][columnnumber]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
