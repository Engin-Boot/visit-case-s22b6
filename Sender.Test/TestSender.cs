using Xunit;

namespace Sender.Test
{
    public class TestSender
    {        
            readonly PrintOnConsole _objTestOfSender = new PrintOnConsole();
            [Fact]
            public void NumberOfRows()
            {
                int countOfLoop = _objTestOfSender.NumberOfRowsPrintingOnConsole();
                Assert.Equal(0, countOfLoop);
            }       
    }
}
