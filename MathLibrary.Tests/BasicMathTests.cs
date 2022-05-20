namespace MathLibrary.Tests;

public class BasicMathTests
{
    [Fact]
    public void Add()
    {
        var result = BasicMath.Add(0, 0);
        Assert.Equal(0, result);
    }
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-3, -4, -7)]
    [InlineData(5, 1, 6)]
    public void AddNegativeNumbers(int a, int b, int expected)
    {
        var result = BasicMath.Add(a, b);
        Assert.Equal(expected, result);
    }
}