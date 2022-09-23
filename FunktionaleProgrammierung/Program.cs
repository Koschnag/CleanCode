// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string [] args)
    {
        var myArray= new []{1,2,3,4,5,6,7,8,9};

        foreach (var i in Filter(myArray, i => i%2==0 ))
        {
            Console.WriteLine(i);
        }
    }

    private static IEnumerable<T> Filter<T>(
        IEnumerable<T> source, 
        Func<T,bool> filterCondition
        )
    {
        foreach (var i in source)
        {
            if (filterCondition(i))
            {
                yield return i;
            }
        }
    }
}


