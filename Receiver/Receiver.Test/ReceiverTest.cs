using System;
using Xunit;

namespace Receiver.Receiver.Test
{ 
    public class ReceiverTest
    {
        readonly FootFall _objfoot = new FootFall();
        [Fact]
        public void Testgetaverageperday()
        {
           double avgDay= _objfoot.GetAveragePerDay(1);
           Assert.Equal(45.7083333333333, avgDay);
        }

        [Fact]
        public void Testgetaverageperweak()
        {
            double avgWeek = _objfoot.GetAveragePerWeek(2);
            Assert.Equal(1837.71428571429, avgWeek);
        }

        [Fact]
        public void Testgetpeekinmonth()
        {
            int peakMonth = _objfoot.GetPeekInMonth(1);
            Assert.Equal(3691, peakMonth);
        }
    }
}
