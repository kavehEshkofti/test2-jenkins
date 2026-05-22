namespace SimpleConsoleApp;

/// <summary>
/// A simple calculator that performs basic arithmetic operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    public double Add(double a, double b) => a + b;

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public double Subtract(double a, double b) => a - b;

    /// <summary>
    /// Multiplies two numbers together.
    /// </summary>
    public double Multiply(double a, double b) => a * b;

    /// <summary>
    /// Divides the first number by the second.
    /// </summary>
    /// <exception cref="DivideByZeroException">Thrown when divisor is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }

    /// <summary>
    /// Returns whether a number is even.
    /// </summary>
    public bool IsEven(int number) => number % 2 == 0;

    /// <summary>
    /// Returns the factorial of a non-negative integer.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when number is negative.</exception>
    public long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.", nameof(number));
        }

        if (number <= 1)
        {
            return 1;
        }

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
