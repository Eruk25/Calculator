namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        double operand1;
        double operand2;
        string operation;
        double? result = null;
        bool isWork = true;
        ICalculator calculator = new Calculator();
        while (isWork)
        { 
            Console.WriteLine("Input a number 1: ");
            if (!double.TryParse(Console.ReadLine(), out operand1))
            { 
                Console.WriteLine("Invalid input for number 1!"); 
                continue;
            }
            
            Console.WriteLine("Input operation: "); 
            operation = Console.ReadLine(); 
            Console.WriteLine("Input a number 2: "); 
            if (!double.TryParse(Console.ReadLine(), out operand2)) 
            { 
                Console.WriteLine("Invalid input for number 2!"); 
                continue;
            }

            switch (operation) 
            { 
                case "+": 
                    result = calculator.Calculate(operand1, operand2, (op1, op2) => op1 + op2); 
                    break;
                case "-": 
                    result = calculator.Calculate(operand1, operand2, (op1, op2) => op1 - op2); 
                    break;
                case "*": 
                    result = calculator.Calculate(operand1, operand2, (op1, op2) => op1 * op2); 
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Division by zero!");
                        continue;
                    }
                    result = calculator.Calculate(operand1, operand2, (op1, op2) => op1 / op2); 
                    break;
                default: 
                    Console.WriteLine("Choice valid operations: +, -, *, /"); 
                    continue;
            }
            Console.WriteLine($"Answer: {result}"); 
            Console.WriteLine("Continue? (Y/N): "); 
            isWork = Console.ReadKey().Key == ConsoleKey.Y ? true : false; 
            Console.Clear();
        }
    }
}