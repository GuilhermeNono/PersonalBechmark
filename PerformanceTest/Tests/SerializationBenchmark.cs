using System.Text.Json;
using BenchmarkDotNet.Attributes;
using PerformanceTest.Objects;

namespace PerformanceTest.Tests;

public class SerializationBenchmark
{
    [Benchmark]
    public Person? Return_SerializeAndDeserializeObject()
    {
        var person = new Person()
        {
            Age = 21,
            Birthdate = DateOnly.FromDateTime(DateTime.Now),
            Cnh = null,
            Cnpj = null,
            Cpf = "999999999",
            Id = 1,
            Name = "Guilherme",
            Rg = "533023587574",
            State = "SP"
        };

        var personSerilized = JsonSerializer.Serialize(person);

        return JsonSerializer.Deserialize<Person>(personSerilized);
    }
    
    [Benchmark]
    public string Return_DeserializeAndSerializeObject()
    {
        var json =
            "{\"Id\":1,\"Name\":\"Guilherme\",\"Age\":21,\"Birthdate\":\"2024-01-04\",\"Cpf\":\"999999999\",\"Cnpj\":null,\"Rg\":\"53303587574\",\"Cnh\":null,\"State\":\"SP\"}";

        var personDeserialized = JsonSerializer.Deserialize<Person>(json);

        return JsonSerializer.Serialize(personDeserialized);
    }

    [Benchmark]
    public Person? Return_OnlyObject() => new()
    {
        Age = 21,
        Birthdate = DateOnly.FromDateTime(DateTime.Now),
        Cnh = null,
        Cnpj = null,
        Cpf = "999999999",
        Id = 1,
        Name = "Guilherme",
        Rg = "53303587574",
        State = "SP"
    };

    [Benchmark]
    public string Return_OnlyTextJson() => "{\"Id\":1,\"Name\":\"Guilherme\",\"Age\":21,\"Birthdate\":\"2024-01-04\",\"Cpf\":\"999999999\",\"Cnpj\":null,\"Rg\":\"53303587574\",\"Cnh\":null,\"State\":\"SP\"}";
}