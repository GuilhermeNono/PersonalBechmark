using BenchmarkDotNet.Attributes;

namespace PerformanceTest.Tests;

[Config(typeof(AntiVirusFriendlyConfig))]
[MemoryDiagnoser]
public class CollectionsBenchmark
{
    private const int MaxNumber = 10000;
    private List<int> _personList;
    private int[] _personArray;

    [GlobalSetup]
    public void Setup()
    {
        _personList = new List<int>(MaxNumber);
        _personArray = new int[MaxNumber];

        for (int i = 0; i < MaxNumber; i++)
        {
            var person = i + 1;
            _personList.Add(i + 1);
            _personArray[i] = person;
        }
    }

    [Benchmark(Baseline = true)]
    public void ListWrite()
    {
        for (int i = 0; i < MaxNumber; i++)
        {
            _personList[i] = i + 1;
        }
    }

    [Benchmark]
    public void ArrayWrite()
    {
        for (int i = 0; i < MaxNumber; i++)
        {
            _personArray[i] = i + 1;
        }
    }

    [Benchmark]
    public int ListRead()
    {
        int sum = 0;
        for (int i = 0; i < MaxNumber; i++)
        {
            sum += _personList[i];
        }
        return sum;
    }

    [Benchmark]
    public int ArrayRead()
    {
        int sum = 0;
        for (int i = 0; i < MaxNumber; i++)
        {
            sum += _personArray[i];
        }
        return sum;
    }

    
    [Benchmark]
    public void Append_A_Stack_Of_5000_Itens()
    {

        var stackBM = new Stack<int>();

        for (int i = 1; i <= 5000; i++)
        {
            stackBM.Push(i);
        }
    }

    [Benchmark]
    public void Append_A_Queue_Of_5000_Itens()
    {

        var queueBM = new Queue<int>();

        for (int i = 1; i <= 5000; i++)
        {
            queueBM.Enqueue(i);
        }
    }

    [Benchmark]
    public void Append_To_A_List_Of_5000_Itens()
    {

        var listBM = new List<int>();

        for (int i = 1; i <= 5000; i++)
        {
            listBM.Add(i);
        }
    }
}