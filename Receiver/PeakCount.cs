using System;
using System.Text;


namespace Receiver
{
    class PeakCount
    {
        public void CheckForPeakCountMontly(int i, StringBuilder content, int[] peakPerMonth)
        {
            if (i < 30)
            {
                content.Append("," + peakPerMonth[0]);
            }
            else { content.Append("," + peakPerMonth[1]); }

        }
    }
}
