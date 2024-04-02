using BenchmarkDotNet.Attributes;

namespace PerformanceTest.Tests;

public class YieldBenchmark
{
    [Benchmark]
    public IEnumerable<int> Return_OrderList500()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 500; i++)
        {
            list.Add(i);
        }

        return list;
    }
    
    [Benchmark]
    public IEnumerable<int> Return_OrderList5000()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 5000; i++)
        {
            list.Add(i);
        }

        return list;
    }
    
    [Benchmark]
    public IEnumerable<int> Return_OrderList50000()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 50000; i++)
        {
            list.Add(i);
        }

        return list;
    }
    [Benchmark]
    public IEnumerable<int> Return_OrderYield500()
    {
        for (int i = 0; i < 500; i++)
        {
            yield return i;
        }
    }
    
    [Benchmark]
    public IEnumerable<int> Return_OrderYield5000()
    {
        for (int i = 0; i < 5000; i++)
        {
            yield return i;
        }
    }
    

    [Benchmark]
    public IEnumerable<int> Return_OrderYield50000()
    {
        for (int i = 0; i < 50000; i++)
        {
            yield return i;
        }
    }
}