using AutoMapperXManualMapper.Models;

namespace AutoMapperXManualMapper.Mappers;
public static class ManualMapper
{
    public static PessoaDTO MapearParaDTO(this Pessoa pessoa)
    {
        return new PessoaDTO
        (
            pessoa.Nome,
            pessoa.Sobrenome,
            pessoa.Profissao,
            pessoa.CreatedAt.ToString("dd/MM/yyyy")
        );
    }
}
