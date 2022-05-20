namespace MathLibrary;

public class BasicMath
{
    // key => "+"
    // value => Méthode qui prend 2 entiers qui retourne un int
    //          Func<in T1, in T2, out TResult> => Func<int, int, int>
    private static readonly Dictionary<string, Func<int, int, int>> Operations = new();

    static BasicMath()
    {
        AddOperation("+", Add);
        AddOperation("-", Subtract);
        AddOperation("*", Multiply);
        AddOperation("/", Divide);
    }

    public static void AddOperation(string operation, Func<int, int, int> callback)
    {
        Operations.Add(operation, callback);
    }

    public static int Calculate(int a, string operation, int b)
    {
        if (!Operations.TryGetValue(operation, out var calculate))
        {
            throw new NotSupportedException($"The operation '{operation}' is not supported.");
        }
        return calculate.Invoke(a, b);
    }
    
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    
    public static int Divide(int a, int b)
    {
        return a / b;
    }

    public static double Sqrt(int a)
    {
        return Math.Sqrt(a);
    }

    private static void Test()
    {
        Action callback = NoParamNoReturn;
        if (callback != null)
        {
            callback();
        }
        
        Action<string> a2 = OneParamNoReturn;
        a2?.Invoke("test");

        //Action<int, string> a3;

        //Func<int> f;
        //Func<int, double> f2;
    }

    private static void OneParamNoReturn(string obj)
    {
    }

    private static void NoParamNoReturn()
    {
    }
}