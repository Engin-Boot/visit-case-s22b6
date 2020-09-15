using System;
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
            
            string filePath = @"c:\csvfolder\casestudy.csv";
            StreamReader sr = new StreamReader(filePath);
            List<string> infoFootfall = new List<string>();
            string Line;
           // int Row = 0;
            while ((Line = sr.ReadLine()) != null)
            {
                infoFootfall.Add(Line);
                //Row++;
            }
            for (int i = 0; i < infoFootfall.Count; i++)
                Console.WriteLine(infoFootfall[i]);
            Console.ReadLine();
        }
    }
}
