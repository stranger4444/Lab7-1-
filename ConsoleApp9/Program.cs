using ConsoleApp9;
class Program
{
    static void Main()
    {
        Calculator<int> intCalculator = new Calculator<int>();
        Calculator<double> doubleCalculator = new Calculator<double>();

        int resultIntAdd = intCalculator.PerformOperation(5, 3, intCalculator.Add);
        int resultIntSubtract = intCalculator.PerformOperation(5, 3, intCalculator.Subtract);
        double resultDoubleMultiply = doubleCalculator.PerformOperation(5.0, 3.0, doubleCalculator.Multiply);
        double resultDoubleDivide = doubleCalculator.PerformOperation(10.0, 2.0, doubleCalculator.Divide);

        Console.WriteLine($"Integer Addition: {resultIntAdd}");
        Console.WriteLine($"Integer Subtraction: {resultIntSubtract}");
        Console.WriteLine($"Double Multiplication: {resultDoubleMultiply}");
        Console.WriteLine($"Double Division: {resultDoubleDivide}");
    }
}