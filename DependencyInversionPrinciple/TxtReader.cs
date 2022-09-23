namespace DependencyInversionPrinciple;

public class TxtReader : IReader
{
    public string Read()
    {
        return File.ReadAllText("test.txt");
    }
}