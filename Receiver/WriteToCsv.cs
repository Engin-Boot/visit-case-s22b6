using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Receiver
{
    class WriteToCsv
    {    
       /* public void CheckForPeakCountMontly(int i,StringBuilder content,int[] peakPerMonth)
        {
            if (i < 30)
            {
                content.Append("," + peakPerMonth[0]);
            }
            else { content.Append("," + peakPerMonth[1]); }
            
        }*/
        public void WriteResultToCsv(double[] avgPerDay, double[] avgPerWeak, int[] peakPerMonth)
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("AveragePerDay,AveragePerWeak,PeakInMonth");
            for (int i = 0; i < 63; i++)
            {
                content.Append(avgPerDay[i]);
                if (i < 8)
                    content.Append(","+avgPerWeak[i]);
                if (i < 2)
                    content.Append("," + peakPerMonth[i]);

                content.AppendLine();
            }

            string path = "c:\\csvfolder\\output.csv";
            File.WriteAllText(path, content.ToString());
        }
    }
}
