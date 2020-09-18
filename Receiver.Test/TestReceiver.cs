using Xunit;
using Receiver;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Receiver.Test
{
    public class TestReceiver
    {
        FootFall _objfoot = new FootFall();
                
        [Fact]
        public void TestAddData()
        {
            _objfoot.AddData("7/1/2020", "9:30 PM");
            int count = _objfoot.internalDictionary.Count;
            Assert.Equal(1,count );
        }

        [Fact]
        public void Testgetaverageperday()
        {
            _objfoot.AddData("7/1/2020", "9:30 PM");
            double avgDay = _objfoot.GetAveragePerDay("7/1/2020");
            Assert.Equal(0, avgDay);
        }

        [Fact]
        public void Testgetaverageperweak()
        {
            _objfoot.AddData("7/1/2020", "9:30 PM");
            List<double> avgWeek = _objfoot.GetAveragePerWeek();
            int avgWeekCount = avgWeek.Count;
            Assert.Equal(1, avgWeekCount);
        }

        [Fact]
        public void Testgetpeekinmonth()
        {
            _objfoot.AddData("7/1/2020", "9:30 PM");
            List<int> peakMonth = _objfoot.GetPeekInMonth();
            int peakMonthCount = peakMonth.Count;
            Assert.Equal(1, peakMonthCount);
        }

        
    }
}
