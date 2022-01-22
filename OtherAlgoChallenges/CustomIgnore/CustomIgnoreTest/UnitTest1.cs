using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CustomIgnore;
using Xunit;

namespace CustomIgnoreTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string[] input = new[]
                {"ignoreMe.txt", "ignoreMe.txt", "doNotIgnore.cs", "doNotIgnore.java", "ignoreMe.exe"};

            List<string> expected = new List<string>
            {
                "doNotIgnore.cs",
                "doNotIgnore.java"
            };

            List<string> actual = Program.GetUnignoredFiles(input);
            Assert.Equal(expected, actual);
        }
    }
}