namespace MathLibrary;

public class BasicStatistics
{
    private readonly INumberReader _reader;
    
    public BasicStatistics(INumberReader reader)
    {
        _reader = reader;
    }
    
    public int SumFromReader()
    {
        var numbers = _reader.ReadNumbers();
        return numbers.Sum();
    }
}