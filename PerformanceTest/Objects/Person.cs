namespace PerformanceTest.Objects;

public class Person
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public DateOnly Birthdate { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public string? Cnpj { get; set; }
    public string Rg { get; set; } = string.Empty;
    public string? Cnh { get; set; }
    public string State { get; set; } = string.Empty;
}