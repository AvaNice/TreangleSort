using TreangleSort;
using Xunit;

namespace TriangleSortTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 12)]
        [InlineData(12, 14, 13, 39)]
        [InlineData(4, 6, 9, 19)]
        public void PerimeterTest(double firstSide, double secondSide, double thirdSide, double expected)
        {
            Triangle triangle = new Triangle("Test", firstSide, secondSide, thirdSide);

            Assert.Equal(triangle.Perimeter, expected);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(12, 14, 13, 72.307935)]
        [InlineData(4, 6, 9, 9.562296)]
        public void AreaTest(double firstSide, double secondSide, double thirdSide, double expected)
        {
            Triangle triangle = new Triangle("Test", firstSide, secondSide, thirdSide);

            Assert.Equal(triangle.Area, expected, 6);
        }

        [Fact]
        public void CompareTestTriangleArea6ToTreangleArea12Expect1()
        {
            int result;
            int expected = 1;
           
            Triangle first = new Triangle("Test", 3, 4, 5);
            Triangle second = new Triangle("Test", 5, 5, 6);

            result = first.CompareTo(second);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void CompareTestTriangleArea6ToTreangleArea6Expect0()
        {
            int result;
            int expected = 0;

            Triangle first = new Triangle("Test", 3, 4, 5);
            Triangle second = new Triangle("Test", 4, 3, 5);

            result = first.CompareTo(second);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void CompareTestTriangleArea12ToTreangleArea6ExpectMinus1()
        {
            int result;
            int expected = -1;

            Triangle first = new Triangle("Test", 5, 5, 6);
            Triangle second = new Triangle("Test", 4, 3, 5);

            result = first.CompareTo(second);

            Assert.Equal(result, expected);
        }
    }
}
