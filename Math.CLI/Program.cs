using MathLibrary;

BasicMath.AddOperation("%", (a, b) => a % b);
BasicMath.AddOperation("bob", (a, b) => -b);

Console.WriteLine(BasicMath.Calculate(2, "+", 5));
Console.WriteLine(BasicMath.Calculate(4, "-", 5));
Console.WriteLine(BasicMath.Calculate(6, "*", 5));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));

try
{
    Console.WriteLine(BasicMath.Calculate(1, "bob", 2));
}
catch (NotSupportedException e)
{
    Console.WriteLine(e);
}

