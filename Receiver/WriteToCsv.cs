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
        public void WriteResultToCsv(double[] avgPerDay, double[] avgPerWeak, int[] peakPerMonth)
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("AveragePerDay,AveragePerWeak,PeakInMonth");
            for (int i = 0; i < 63; i++)
            {
                content.Append(avgPerDay[i]);
                if (i < 8)
                {
                    content.Append("," + avgPerWeak[0]);
                }
                else if (i > 7 && i < 16)
                {
                    content.Append("," + avgPerWeak[1]);
                }
                else if (i > 15 && i < 24)
                {
                    content.Append("," + avgPerWeak[2]);
                }
                else if (i > 23 && i < 32)
                {
                    content.Append("," + avgPerWeak[3]);
                }
                else if (i > 31 && i < 40)
                {
                    content.Append("," + avgPerWeak[4]);
                }
                else if (i > 39 && i < 48)
                {
                    content.Append("," + avgPerWeak[5]);
                }
                else if (i > 47 && i < 56)
                {
                    content.Append("," + avgPerWeak[6]);
                }
                else
                {
                    content.Append("," + avgPerWeak[7]);
                }

                if (i < 30)
                {
                    content.Append("," + peakPerMonth[0]);
                }
                else
                {
                    content.Append("," + peakPerMonth[1]);
                }

                content.AppendLine();
            }

            string path = "c:\\csvfolder\\output.csv";
            File.WriteAllText(path, content.ToString());
        }
    }
}
