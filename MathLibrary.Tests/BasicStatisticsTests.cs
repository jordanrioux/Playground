using System.Collections.Generic;

namespace MathLibrary.Tests;

public class BasicStatisticsTests
{
    private class MockNumberReader : INumberReader
    {
        public IEnumerable<int> ReadNumbers()
        {
            return new[] { 1, 2, 3, 4, 5 };
        }
    }
    
    [Fact]
    public void SumFromReader()
    {
        var statistics = new BasicStatistics(new MockNumberReader());
        var sum = statistics.SumFromReader();
        Assert.Equal(15, sum);
    }
}