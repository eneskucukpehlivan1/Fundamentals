using UnitTestExample;

namespace TestProject
{
    public class MathTest : IClassFixture<Mathematics>
    {

        Mathematics _math;
        public MathTest(Mathematics math)
        {
            _math = math;
        }
        public static IEnumerable<object[]> divideDatas => new List<object[]>
        {
            new object[]{50,10,5},
            new object[]{100,25,4},
            new object[]{1000,25,40},
            new object[]{1534,21,73}
        };

        [Fact]
        public void SubtractTest()
        {
            Assert.Equal(5, _math.Subtract(10, 5));
        }

        [Fact]
        public void SumTest()
        {
            Assert.Equal(75, _math.Sum(30, 45));
        }

        [Fact]
        public void MulTest()
        {
            Assert.Equal(15, _math.Multiply(3, 5));
        }

        [Theory]
        [MemberData(nameof(divideDatas))]
        public void DivideTest(int number1, int number2, int expected)
        {
            Assert.Equal(expected, _math.Divide(number1, number2));
        }
    }
}