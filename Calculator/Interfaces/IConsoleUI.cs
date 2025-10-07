namespace Calculator;

public interface IConsoleUi
{
    public double ReadOperand(string prompt);
    public void Write(string prompt);
    public void Run();
    public string ReadOperation(string prompt);
    public bool AskToContinue();
}