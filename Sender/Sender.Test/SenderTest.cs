﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sender.Sender.Test
{
    public class SenderTest
    {
        PrintOnConsole objTestOfSender = new PrintOnConsole();
        [Fact]
        public void NumberOfRows()
        {
            int countOfLoop = objTestOfSender.NumberOfRowsPrintingOnConsole();
            Assert.Equal(60, countOfLoop);
        }
    }
}