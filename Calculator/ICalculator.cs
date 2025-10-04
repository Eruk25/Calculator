namespace Calculator;

public interface ICalculator
{
    public double Calculate(double operand1, double operand2, Func<double, double, double> operation);
}