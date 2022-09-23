namespace DependencyInversionPrinciple;

public class Copy
{
    private readonly IWriter wr;
    private readonly IReader rd;

    public Copy(IReader reader,IWriter writer)
    {
        this.rd = reader;
        this.wr = writer;
    }

    public void ReadAndWrite()
    {
        var text= rd.Read();
        wr.Write(text);
    }
}

public interface ICopy
{
    void ReadAndWrite();
}