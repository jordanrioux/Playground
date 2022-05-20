namespace MathLibrary;

public class ExtendedMath : BasicMath
{
    public ExtendedMath() : base()
    {
        AddOperation("%", (a, b) => a % b);
        AddOperation("abs", (a, b) => -b);
    }
}