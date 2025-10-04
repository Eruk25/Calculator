namespace Calculator;

public class Calculator : ICalculator
{
    public double Calculate(double operand1, double operand2, Func<double, double, double> operation)
    {
        return operation(operand1, operand2);
    }
}