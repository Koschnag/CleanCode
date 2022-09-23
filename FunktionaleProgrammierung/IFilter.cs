namespace FunktionaleProgrammierung;

public interface IFilter
{
    IEnumerable<int> Execute(IEnumerable<int> myArray);
}