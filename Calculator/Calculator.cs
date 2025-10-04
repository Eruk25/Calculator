namespace Calculator;

public class Calculator : ICalculator
{
    public double Calculate(double operand1, double operand2, Func<double, double, double> operation)
    {
        return operation(operand1, operand2);
    }

    public double Add(double operand1, double operand2) => operand1 + operand2;

    public double Substract(double operand1, double operand2) => operand1 - operand2;

    public double Multiply(double operand1, double operand2) => operand1 * operand2;

    public double Divide(double operand1, double operand2)
    {
        if(operand2 == 0)
            throw new DivideByZeroException();
        return operand1 / operand2;
    }
}