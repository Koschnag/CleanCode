namespace DependencyInversionPrinciple;

public class TxtWriter : IWriter
{
    public void Write(string text)
    {
        File.WriteAllText("test.txt",text);
    }
}