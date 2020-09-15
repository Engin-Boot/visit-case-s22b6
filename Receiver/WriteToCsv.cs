using System;
using System.Text;
using System.IO;
namespace Receiver
{
    class WriteToCsv
    {
         private void CheckForPeakCountMontly(int i,StringBuilder content,int[] peakPerMonth)
         {
                  if (i < 2) { content.Append("," + peakPerMonth[i]); }
         }
        private void CheckForWeaklyAvg(int i, StringBuilder content, double[] avgPerWeak)
        {
            if (i < 8) { content.Append("," + avgPerWeak[i]); }
        }
        public void WriteResultToCsv(double[] avgPerDay, double[] avgPerWeak, int[] peakPerMonth)
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("AveragePerDay,AveragePerWeak,PeakInMonth");
            for (int i = 0; i < 63; i++)
            {
                content.Append(avgPerDay[i]);
                
                
                CheckForWeaklyAvg(i, content, avgPerWeak);
                CheckForPeakCountMontly(i, content, peakPerMonth);

                content.AppendLine();
            }

            string path = "c:\\csvfolder\\output.csv";
            File.WriteAllText(path, content.ToString());
        }
    }
}
