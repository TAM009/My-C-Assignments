using System;
using Xunit;
using TestCode;

namespace TomJerry.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Codetest cd =new Codetest();

            //Act
            bool re1=cd.ToPrintTom(25);
            bool re2=cd.ToPrintTom(26);
            bool re5=cd.ToPrintTom(15);
            bool re3=cd.ToPrintJerry(28);
            bool re4=cd.ToPrintJerry(27);
            bool re6=cd.ToPrintJerry(35);

            //Assert
            Assert.True(re1);
            Assert.False(re2);
            Assert.False(re5);
            Assert.True(re3);
            Assert.False(re4);
            Assert.False(re6);
            

        }
    }
}
