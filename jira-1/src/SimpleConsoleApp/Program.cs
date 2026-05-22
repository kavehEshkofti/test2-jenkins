using SimpleConsoleApp;

var calculator = new Calculator();

Console.WriteLine("=== Simple Calculator ===");
Console.WriteLine();

Console.WriteLine($"  5 + 3 = {calculator.Add(5, 3)}");
Console.WriteLine($"  10 - 4 = {calculator.Subtract(10, 4)}");
Console.WriteLine($"  6 * 7 = {calculator.Multiply(6, 7)}");
Console.WriteLine($"  20 / 4 = {calculator.Divide(20, 4)}");
Console.WriteLine();

Console.WriteLine($"  Is 4 even? {calculator.IsEven(4)}");
Console.WriteLine($"  Is 7 even? {calculator.IsEven(7)}");
Console.WriteLine();

Console.WriteLine($"  5! = {calculator.Factorial(5)}");
Console.WriteLine($"  0! = {calculator.Factorial(0)}");

Console.WriteLine();
Console.WriteLine("Done!");
