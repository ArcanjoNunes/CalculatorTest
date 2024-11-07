namespace CalculatorTest;

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

    [Fact(DisplayName = "Divide by zero Exception")]
    public void DivideBy_ShouldReturn_ThrowsException()
    {
        // Arrange
        var calcParam = new CalculatorParameter(200, 0);

        // Act
        var exception = Assert.Throws<DivideByZeroException>(() => _calculatorRepository.DivideBy(calcParam));

        // Assert
        Assert.Equal("Attempted to divide by zero.", exception.Message);
    }

    [Fact(Skip = "Skipped...")]
    public void Add_Skipped()
    {
        // Arrange
        var calcParam = new CalculatorParameter(80, 20);

        // Act
        double result = _calculatorRepository.Add(calcParam);

        // Assert
        Assert.Equal(100, result);
    }

    [Theory(DisplayName = "Divided By Parameters")]
    [InlineData(10, 2, 5)]
    public void DivideByParams(double v1, double v2, double result)
    {
        // Arrange
        var calcParam = new CalculatorParameter(v1, v2);

        // Act
        double resultCalc = _calculatorRepository.DivideBy(calcParam);

        // Assert
        Assert.Equal(result, resultCalc, 0);
    }
}