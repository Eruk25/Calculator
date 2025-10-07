using System.Globalization;

namespace Calculator;

public class Calculator : ICalculator
{
    public double Calculate(double operand1, double operand2, Func<double, double, double> operation)
    {
        return operation(operand1, operand2);
    }

    public Func<double, double, double> DefineOperation(string operation)
    {
        return operation switch
        {
            "+" => (op1, op2) => op1 + op2,
            "-" => (op1, op2) => op1 - op2,
            "*" => (op1, op2) => op1 * op2,
            "/" => (op1, op2) => op1 / op2,
        };
    }

    public bool IsSupportedOperation(string operation)
        => new [] {"+", "-", "*", "/"}.Contains(operation);
}