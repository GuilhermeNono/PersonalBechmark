using BenchmarkDotNet.Attributes;

namespace PerformanceTest.Tests;

public class CollectionsBenchmark
{
    [Benchmark]
    public void Producing_A_List_Of_5000_Itens()
    {

        var listBM = new List<int>();
        
        for (int i = 1; i <= 5000; i++)
        {
            listBM.Add(i);
        }
    }
    
    [Benchmark]
    public void Producing_A_Stack_Of_5000_Itens()
    {

        var stackBM = new Stack<int>();
        
        for (int i = 1; i <= 5000; i++)
        {
            stackBM.Push(i);
        }
    }
    
    [Benchmark]
    public void Producing_A_Queue_Of_5000_Itens()
    {

        var queueBM = new Queue<int>();
        
        for (int i = 1; i <= 5000; i++)
        {
            queueBM.Enqueue(i);
        }
    }
}