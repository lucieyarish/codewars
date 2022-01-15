using System;
using Xunit;

namespace TextExchangeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string input = "The class starts in 3 HR or so.";
            
            string expected = "The class starts in 180 MIN or so.";

            string actual = TextExchangeAlgo.Program.GetTextExchange(input);

        }
    }
}