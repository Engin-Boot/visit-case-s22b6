namespace Receiver.Test
{
    class ReceiverTestUtility
    {
        readonly TestReceiver testReceiver = new TestReceiver();
        ReceiverTestUtility()
        {
            testReceiver.TestAddData();
            testReceiver.Testgetaverageperday();
            testReceiver.Testgetaverageperweak();
            testReceiver.Testgetpeekinmonth();
        }

    }
}
