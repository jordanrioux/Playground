using MathLibrary;

BasicMath.AddOperation("%", (a, b) => a % b);
BasicMath.AddOperation("bob", (a, b) => -b);

Console.WriteLine(BasicMath.Calculate(2, "+", 5));

Console.WriteLine(BasicMath.Calculate(1, "/", 177));

Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));

Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
Console.WriteLine(BasicMath.Calculate(1, "/", 2));
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


// Test Why stop it get some help Yvon You commited war crime