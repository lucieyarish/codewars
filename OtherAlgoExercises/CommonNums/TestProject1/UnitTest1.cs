using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] input1 = new[] {1, 2, 5};
            int[] input2 = new[] {1, 2, 4, 5};
            
            List<int> expected = new List<int>{ 1, 2, 5};

            List<int> actual = CommonNums.Program.FindCommonNums(input1, input2);
            
            Assert.Equal(expected, actual);

        }
    }
}