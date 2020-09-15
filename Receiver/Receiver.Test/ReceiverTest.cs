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
        readonly FootFall foot = new FootFall();
        [Fact]
        public void Testgetaverageperday()
        {
           double avgDay= foot.getaverageperday(1);
           Assert.Equal(45.7083333333333, avgDay);
        }

        [Fact]
        public void Testgetaverageperweak()
        {
            double avgWeek = foot.getaverageperweak(2);
            Assert.Equal(1837.71428571429, avgWeek);
        }

        [Fact]
        public void Testgetpeekinmonth()
        {
            int peakMonth = foot.getpeekinmonth(1);
            Assert.Equal(3691, peakMonth);
        }
    }
}
