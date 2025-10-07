namespace Calculator;

public class ConsoleUi : IConsoleUi
{
    public ICalculator Calculator {private get; set; }
    
    public ConsoleUi(ICalculator calculator)
    {
        Calculator = calculator;
    }
    public double ReadOperand(string? prompt = null)
    {
        while (true)
        {
            if (prompt != null)
            {
                Write(prompt);
            }
            
            if (double.TryParse(Console.ReadLine(), out double operand))
                return operand;
            
            Console.WriteLine("Invalid input for number!");
        }
        
    }

    public void Write(string prompt)
    {
        Console.WriteLine(prompt);
    }

    public void Run()
    {
        double operand1;
        double operand2;
        string operation;
        bool isWork = true;
        while (isWork)
        {
            try
            { 
                operand1 = ReadOperand("Input a number 1: "); 
                operation = ReadOperation("Enter operation: "); 
                operand2 = ReadOperand("Input a number 2: ");
                
                ShowResult(Calculator.Calculate(operand1, operand2, Calculator.DefineOperation(operation)));
            }
            catch (DivideByZeroException e) 
            { 
                Console.WriteLine(e.Message);
            }

            isWork = AskToContinue();
        }
        
    }

    public string ReadOperation(string? prompt = null)
    {
        string input; 
        while (true)
        {
            if (prompt != null)
                Write(prompt);
                
            input = Console.ReadLine();
            if (Calculator.IsSupportedOperation(input))
                return input;
            Console.WriteLine("Invalid operation! Choose +, -, *, /");
        }
    }

    public bool AskToContinue()
    {
        Console.WriteLine("Continue? (Y/N): "); 
        return Console.ReadKey().Key == ConsoleKey.Y ? true : false; 
    }

    public void ShowResult(double result)
    {
        Console.WriteLine($"Answer: {result}");
    }
}