using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
