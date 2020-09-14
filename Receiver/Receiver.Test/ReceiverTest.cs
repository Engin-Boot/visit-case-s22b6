using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Receiver.Receiver.Test
{
    public class ReceiverTest
    {
        footfall foot = new footfall();
        [Fact]
        public void Testgetaverageperday()
        {
           int avgDay= (int)foot.getaverageperday(1097);
           Assert.Equal(45, avgDay);
        }

        [Fact]
        public void Testgetaverageperweak()
        {
            int avgWeek = (int)foot.getaverageperweak(1);
            Assert.Equal(23, avgWeek);
        }

        [Fact]
        public void Testgetpeekinmonth()
        {
            int peakMonth = foot.getpeekinmonth(1);
            Assert.Equal(1097, peakMonth);
        }
    }
}
