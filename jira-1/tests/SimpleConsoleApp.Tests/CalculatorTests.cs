using SimpleConsoleApp;

namespace SimpleConsoleApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    #region Add

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, -8)]
    [InlineData(1.5, 2.5, 4.0)]
    public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.Equal(expected, result);
    }

    #endregion

    #region Subtract

    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, -2)]
    [InlineData(1, 5, -4)]
    public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.Equal(expected, result);
    }

    #endregion

    #region Multiply

    [Theory]
    [InlineData(6, 7, 42)]
    [InlineData(0, 100, 0)]
    [InlineData(-3, 4, -12)]
    [InlineData(-2, -5, 10)]
    public void Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.Equal(expected, result);
    }

    #endregion

    #region Divide

    [Theory]
    [InlineData(20, 4, 5)]
    [InlineData(10, 3, 3.3333333333333335)]
    [InlineData(-10, 2, -5)]
    public void Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        var exception = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));

        Assert.Equal("Cannot divide by zero.", exception.Message);
    }

    #endregion

    #region IsEven

    [Theory]
    [InlineData(4, true)]
    [InlineData(7, false)]
    [InlineData(0, true)]
    [InlineData(-2, true)]
    [InlineData(-3, false)]
    public void IsEven_ShouldReturnCorrectResult(int number, bool expected)
    {
        var result = _calculator.IsEven(number);

        Assert.Equal(expected, result);
    }

    #endregion

    #region Factorial

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void Factorial_ShouldReturnCorrectResult(int number, long expected)
    {
        var result = _calculator.Factorial(number);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Factorial_NegativeNumber_ShouldThrowArgumentException()
    {
        var exception = Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1));

        Assert.Contains("Factorial is not defined for negative numbers", exception.Message);
    }

    #endregion
}
