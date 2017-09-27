using System;
using Xunit;
using NumPalin;

namespace PalindromeNumber.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            PalindromeTest P= new PalindromeTest();
            SumCheckTest s= new SumCheckTest();

            //Act
            bool re1= P.  IsAPalindrome(1234321);
            bool re2= P.  IsAPalindrome(1234531);
            bool re3= s.  IsSumGreater(68886);
            bool re4= s.  IsSumGreater(1221);

            //Assert
            Assert.True(re1);
            Assert.False(re2);
            Assert.True(re3);
            Assert.False(re4);

        }
    }
}
