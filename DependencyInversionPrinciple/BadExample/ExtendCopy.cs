namespace DependencyInversionPrinciple.BadExample;

public class ExtendCopy
{
    public void ReadAndWrite(string inputTarget, string outputTarget)
    {
        string input="";
        if (inputTarget == "console")
        {
            input= Console.ReadLine();
        }
        if (inputTarget == "txt")
        {
            input = File.ReadAllText("test.txt");
        }
        if (outputTarget == "console")
        {
            Console.WriteLine(input);
        }
        if (outputTarget == "txt")
        {
            File.WriteAllText("test.txt",input);
        }
    }
}