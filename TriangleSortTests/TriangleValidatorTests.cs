using System;
using TreangleSort;
using Xunit;

namespace TriangleSortTests
{
    public class TriangleValidatorTests
    {
        [Theory]
        [InlineData(321, 4, 5)]
        [InlineData(-5, -5, -5)]
        [InlineData(0, 0, 0)]
        public void ValidatorWrongSideExpectFalse(double firstSide, double secondSide, double thirdSide)
        {          
            TriangleValidator validator = new TriangleValidator();
            Triangle triangle = new Triangle("Test", firstSide, secondSide, thirdSide);

            Assert.False(validator.Validate(triangle).IsValid);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(7, 17, 16)]
        [InlineData(11, 17.5, 7)]
        public void ValidatorRightSideExpectTrue(double firstSide, double secondSide, double thirdSide)
        {
            TriangleValidator validator = new TriangleValidator();
            Triangle triangle = new Triangle("Test", firstSide, secondSide, thirdSide);

            Assert.True(validator.Validate(triangle).IsValid);
        }
    }
}
