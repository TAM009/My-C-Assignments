using System;
using Xunit;
using Testcode;

namespace vowcosn.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            VowConsTest v = new VowConsTest();

            //Act
            bool re1= v.IfNotLetter('1');
            bool re6 = v.IfNotLetter('a');
            bool re2= v.IfVowel('a');
            bool re3= v.IfVowel('p');
            bool re5 = v.IfConsonant('u');

            //Assert
            Assert.True(re1);
            Assert.False(re6);
            Assert.True(re2);
            Assert.False(re3);
            





        }
    }
}
