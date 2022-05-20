Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));

BasicMath.AddOperation("%", (a, b) => a % b);
BasicMath.AddOperation("bob", (a, b) => -a);

Console.WriteLine(BasicMath.Calculate(2, "+", 5));


Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));



try
{
    Console.WriteLine(BasicMath.Calculate(1, "bob", 2));
}
catch (NotSupportedException e)
{
    Console.WriteLine(e);
}


// OWO UWU OWO