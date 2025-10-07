namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        IConsoleUi consoleUi = new ConsoleUi(new Calculator());
        consoleUi.Run();
    }
}