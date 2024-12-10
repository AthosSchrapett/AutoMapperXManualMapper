namespace AutoMapperXManualMapper.Models;
public class Pessoa
{
    public int Id { get; private set; }
    public string? Nome { get; private set; }
    public string? Sobrenome { get; private set; }
    public string? Profissao { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Pessoa(int id, string nome, string sobrenome, string profissao, DateTime createdAt)
    {
        Id = id;
        Nome = nome;
        Sobrenome = sobrenome;
        Profissao = profissao;
        CreatedAt = createdAt;
    }
}
