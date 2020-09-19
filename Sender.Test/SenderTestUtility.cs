namespace Sender.Test
{
    class SenderTestUtility
    {
        readonly TestSender testSender = new TestSender();
        SenderTestUtility()
        {
            testSender.NumberOfRows();
        }
    }

}
