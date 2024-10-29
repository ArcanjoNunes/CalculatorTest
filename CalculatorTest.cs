using CalculatorWebApi.Infra;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        private readonly CalculatorRepository _calculatorRepository;

        public CalculatorTest()
        {
            if (_calculatorRepository is null)
            {
                _calculatorRepository = new CalculatorRepository();
            }
        }

        [Fact]
        public void Add_ShouldReturn_100()
        {
            // Arrange
            var calcParam = new CalculatorParameter(80, 20);

            // Act
            double result = _calculatorRepository.Add(calcParam);

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void Subtract_ShouldReturn_100()
        {
            // Arrange
            var calcParam = new CalculatorParameter(180, 80);

            // Act
            double result = _calculatorRepository.Subtract(calcParam);

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void Multiply_ShouldReturn_100()
        {
            // Arrange
            var calcParam = new CalculatorParameter(80, 1.25);

            // Act
            double result = _calculatorRepository.Multiply(calcParam);

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void DivideBy_ShouldReturn_100()
        {
            // Arrange
            var calcParam = new CalculatorParameter(200, 2);

            // Act
            double result = _calculatorRepository.DivideBy(calcParam);

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void DivideBy_ShouldReturn_ThrowsException()
        {
            // Arrange
            var calcParam = new CalculatorParameter(200, 0);

            // Act
            var exception = Assert.Throws<DivideByZeroException>(() => _calculatorRepository.DivideBy(calcParam));

            // Assert
            Assert.Equal("Attempted to divide by zero.", exception.Message);
        }
    }
}