using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sender.Sender.Test
{
    public class SenderTest
    {
        readonly PrintOnConsole objTestOfSender = new PrintOnConsole();
        [Fact]
        public void NumberOfRows()
        {
            int countOfLoop = objTestOfSender.NumberOfRowsPrintingOnConsole();
            Assert.Equal(63, countOfLoop);
        }
    }
}
