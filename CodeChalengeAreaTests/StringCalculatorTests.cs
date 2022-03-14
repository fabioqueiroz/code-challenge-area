using CodeChallengeArea;
using System;
using Xunit;

namespace CodeChalengeArea.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator _stringCalculator;
        public StringCalculatorTests()
        {
            _stringCalculator = new StringCalculator();
        }

        [Fact]
        public void IfTheStringIsEmpty_TheResultIsZero()
        {
            // Arrange
            var numbers = string.Empty;

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void IfTheStringIsNotEmpty_TheResultIsOutput()
        {
            // Arrange
            var numbers = "1";

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void IfTheStringHasTwoNumbers_TheResultIsTheirSum()
        {
            // Arrange
            var numbers = "1,2";

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void IfTheStringHas_SeveralNumbers_TheResultIsTheirSum()
        {
            // Arrange
            var numbers = "1,2, 4,  6";

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void IfTheStringHas_CharsOtherThanNumbers_TheirValueShouldBeIgnored()
        {
            // Arrange
            var numbers = "1,2, xxxx, 5";

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void IfTheStringHas_NewLines_TheyShouldBeHandled()
        {
            // Arrange
            var numbers = "1\n2,3";

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void IfTheStringHas_OtherDelimiters_TheyShouldBeHandled()
        {
            // Arrange
            var numbers = "//;\n1;2\n;4";

            // Act
            var result = _stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void IfTheStringHas_NegativeNumbers_AnExceptionIsThrown()
        {
            // Arrange
            var numbers = "//;\n1;-2\n;-4";

            // Act and Assert
            Assert.ThrowsAny<ApplicationException>(() => _stringCalculator.Add(numbers));
        }

        [Fact]
        public void IfTheStringHas_MultipleDelimiters_TheyShouldBeHandled()
        {
            // Arrange
            var firstNumbers = "//[*][%]\n1*2%3";
            var secondNumbers = "//[***]\n1***2***3";

            // Act
            var firstResult = _stringCalculator.Add(firstNumbers);
            var secondResult = _stringCalculator.Add(secondNumbers);

            // Assert
            Assert.Equal(6, firstResult);
            Assert.Equal(6, secondResult);
        }
    }
}
