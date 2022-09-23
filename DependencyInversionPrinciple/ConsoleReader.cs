namespace DependencyInversionPrinciple;

public class ConsoleReader : IReader
{
    public string Read()
    {
        return Console.ReadLine();
    }
}