using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:


            //Arrange
            // create a Calculator object

            var calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calc.Add(num1, num2, num3);

            //Assert
             Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 7, 5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtCalc = new Calculator();

            //Act
            var subtActual = subtCalc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, subtActual);

        }

        [Theory]
        [InlineData(25, 6, 150)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multCalc = new Calculator();

            //Act
            var subtActual = multCalc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, subtActual);
        }

        [Theory]
        [InlineData(265, 5, 53)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divCalc = new Calculator();

            //Act
            var divActual = divCalc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, divActual);
        }

    }
}
