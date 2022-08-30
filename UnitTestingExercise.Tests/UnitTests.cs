using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:..

            //Arrange
            // create a Calculator object
            var create = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = create.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,3,7)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtract = new Calculator();

            //Act
            var actual = subtract.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var times = new Calculator();

            //Act
            var actual = times.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,10,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new Calculator();

            //Act
            var actual = divide.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
