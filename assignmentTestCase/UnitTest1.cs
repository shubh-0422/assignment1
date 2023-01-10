using System;
using Xunit;
using LenghtHelper;


namespace assignmentTestCase
{
    public class UnitTest1
    {
        [Fact]
        public void validEqualTest()
        {
            Assert.Equal(4, LenghtHelper.LengthHelper.lengthFinder("abcd"));

        }
        [Fact]
        public void notValidEqualTest()
        {
            Assert.NotEqual(12, LenghtHelper.LengthHelper.lengthFinder("abcdefg"));

        }
        [Theory]
        [InlineData("abcde")]
        [InlineData("hello")]
        [InlineData("shubh")]
        [InlineData("abpsfde")]
        public void ValidMultiEqualTest(string input)
        {
            Assert.True(input.Length == LenghtHelper.LengthHelper.lengthFinder(input));

        }
        [Theory]
        [InlineData("abcde")]
        [InlineData("hello")]
        [InlineData("shubh")]
        [InlineData("abpsfde")]
        public void NotValidMultiEqualTest(string input)
        {
            Assert.False(input.Length+1 == LenghtHelper.LengthHelper.lengthFinder(input));

        }
    }
}
