using System;
using Xunit;

namespace Sender.Sender.Test
{
    public class SenderTest
    {
        readonly PrintOnConsole _objTestOfSender = new PrintOnConsole();
        [Fact]
        public void NumberOfRows()
        {
            int countOfLoop = _objTestOfSender.NumberOfRowsPrintingOnConsole();
            Assert.Equal(63, countOfLoop);
        }
    }
}
