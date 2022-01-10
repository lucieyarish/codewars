using System;
using System.Collections.Generic;
using Xunit;

namespace NumbersUnionTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] input1 = new[] {1, 2, 3};
            int[] input2 = new[] {2, 3, 4};

            List<int> expected = new List<int>() {1, 2, 3, 4};

            List<int> actual = NumbersUnion.Program.GetNumUnion(input1, input2);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Test2()
        {
            int[] input1 = new[] {0};
            int[] input2 = new[] {0};

            List<int> expected = new List<int>() {0};

            List<int> actual = NumbersUnion.Program.GetNumUnion(input1, input2);
            
            Assert.Equal(expected, actual);
        }
    }
}