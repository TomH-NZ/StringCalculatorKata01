using System;
using System.Runtime.InteropServices;
using StringCalculatorKata01;
using Xunit;

namespace StringCalculatorKataUnit01Tests
{
    public class KataShould
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        [InlineData("5", 5)]
        [InlineData("", 0)]
        public void ReturnSingleValues(string inputValue, int outputValue)
        {
            //Arrange
            var result = Calculator.StringCalculator(inputValue);
            //Act
            //Assert
            Assert.Equal(outputValue, result);
        }
        
        [Fact]
        public void AddTwoNumbersFact()
        {
            //Arrange
            var result = Calculator.StringCalculator("3, 1");
            //Act
            //Assert
            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData("1,3", 4)]
        [InlineData("7,3", 10)]
        [InlineData("1,1", 2)]
        [InlineData("9,1",10)]
        public void AddTwoNumbers(string inputString, int outputValue)
        {
            //Arrange
            var result = Calculator.StringCalculator(inputString);
            //Act
            //Assert
            Assert.Equal(outputValue, result);
        }
        
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,4,6", 12)]
        [InlineData("3,3,3", 9)]
        [InlineData("5,6,9", 20)]
        public void AddMultipleNumbers(string inputString, int outputValue)
        {
            //Arrange
            var result = Calculator.StringCalculator(inputString);
            //Act
            //Assert
            Assert.Equal(outputValue, result);
        }

        [Theory]
        [InlineData("1,2\n3", 6)]
        [InlineData("3\n5\n3,9", 20)]
        [InlineData("1\n3,5\n7", 16)]
        [InlineData("2,3,5\n7", 17)]
        public void UseTwoDelimiters(string inputString, int outputValue)
        {
            //Arrange
            var result = Calculator.StringCalculator(inputString);
            //Act
            //Assert
            Assert.Equal(outputValue, result);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//q\n1q2q3", 6)]
        [InlineData("//--\n2--4--6", 12)]
        [InlineData("//;\n1;2;3;4", 10)]
        public void UseCustomDelimiter(string inputString, int outputValue)
        {
            //Arrange
            var result = Calculator.StringCalculator(inputString);
            //Act
            //Assert
            Assert.Equal(outputValue, result);
        }
    }
}
// write doc on testing.