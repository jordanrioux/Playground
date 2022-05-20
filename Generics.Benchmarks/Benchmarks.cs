using BenchmarkDotNet.Attributes;

namespace Generics.Benchmarks;

[MemoryDiagnoser]
public class Benchmarks
{
    private const string Test = "        hdhsfhjfdshjfdsdfdsjkjdfsjkdffdsdfsdsfdfsdfsdfdfsdfshjsfds         ";
    
    [Benchmark]
    public bool IsWhiteSpace() => StringUtils.IsWhiteSpace(Test);

    [Benchmark]
    public bool IsWhiteSpace2()
    {
        return StringUtils.IsWhiteSpace2(Test);
    }

}