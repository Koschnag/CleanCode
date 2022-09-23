namespace FunktionaleProgrammierung;

public class FilterEven:IFilter
{
    public IEnumerable<int> Execute(IEnumerable<int> myArray)
    {
        foreach (var i in myArray)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }
        }
    }
}