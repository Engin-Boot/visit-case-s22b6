using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Receiver
{
    class WriteToCsv
    {
         private void CheckForPeakCountMontly(int i,StringBuilder content,List<int> peakPerMonth,FootFall foot)
         {
                  if (i < foot.GetDateCount() / 30) { content.Append("," + peakPerMonth[i]); }
         }
        private void CheckForWeaklyAvg(int i, StringBuilder content, List<double> avgPerWeak, FootFall foot)
        {
            if (i < foot.GetDateCount() / 7) { content.Append("," + avgPerWeak[i]); }
        }
        public void WriteResultToCsv(List<double> avgPerDay, List<double> avgPerWeak, List<int> peakPerMonth,FootFall foot)
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("AveragePerDay,AveragePerWeak,PeakInMonth");
            for (int i = 0; i < foot.GetDateCount() - 1; i++)
            {
                content.Append(avgPerDay[i]);
                
                
                CheckForWeaklyAvg(i, content, avgPerWeak,foot);
                CheckForPeakCountMontly(i, content, peakPerMonth,foot);

                content.AppendLine();
            }

            string path = "c:\\csvfolder\\output.csv";
            File.WriteAllText(path, content.ToString());
        }
    }
}
