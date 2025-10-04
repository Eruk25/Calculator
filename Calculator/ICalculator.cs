namespace Calculator;

public interface ICalculator
{
    public double Calculate(double operand1, double operand2, Func<double, double> operation);
    public double Add(double a, double b);
    public double Substract(double a, double b);
    public double Multiply(double a, double b);
    public double Divide(double a, double b);
}