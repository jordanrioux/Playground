namespace MathLibrary;

public abstract class NumberReaderBase
{
    public abstract IEnumerable<int> ReadNumbers();
}

public interface INumberReader
{
    public IEnumerable<int> ReadNumbers();
}

internal class NumberReader : INumberReader
{
    public IEnumerable<int> ReadNumbers()
    {
        var fileContent = File.ReadAllText("numbers.txt");
        var numbers = new List<int>();
        foreach (var valueText in fileContent.Split(","))
        {
            numbers.Add(int.Parse(valueText));
        }
        return numbers;
        //return fileContent.Split(",").Select(valueText => int.Parse(valueText));
    }
}