using System.Linq.Expressions;

namespace Calculator;

public interface ICalculator
{
    public double Calculate(double operand1, double operand2, Func<double, double, double> operation);
    public Func<double, double, double> DefineOperation(string operation);
    public bool IsSupportedOperation(string operation);
}