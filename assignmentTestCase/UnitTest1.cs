using System;
using Xunit;
using LenghtHelper;


namespace assignmentTestCase
{
    public class UnitTest1
    {
        [Fact]
        public void testCase1()
        {
            LengthHelper LH = new LengthHelper();
            Assert.Equal(0, LH.lengthFinder(""));

        }
        [Fact]
        public void testCase2()
        {
            LengthHelper LH = new LengthHelper();
            Assert.Equal(3, LH.lengthFinder("123"));

        }
        [Fact]
        public void testCase3()
        {
            LengthHelper LH = new LengthHelper();
            Assert.Equal(12, LH.lengthFinder("123456789010"));

        }
        [Fact]
        public void testCase4()
        {
            LengthHelper LH = new LengthHelper();
            Assert.Equal(0, LH.lengthFinder());

        }
        [Fact]
        public void validEqualTest()
        {
            LengthHelper LH = new LengthHelper();
            Assert.Equal(4, LH.lengthFinder("abcd"));

        }
        [Fact]
        public void notValidEqualTest()
        {
            LengthHelper LH = new LengthHelper();
            Assert.NotEqual(12, LH.lengthFinder("abcdefg"));

        }
        [Theory]
        [InlineData("abcde")]
        [InlineData("hello")]
        [InlineData("shubh")]
        [InlineData("abpsfde")]
        public void ValidMultiEqualTest(string input)
        {
            LengthHelper LH = new LengthHelper();
            Assert.True(input.Length == LH.lengthFinder(input));

        }

    }
}
