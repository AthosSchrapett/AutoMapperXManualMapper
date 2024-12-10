using AutoMapper;
using AutoMapperXManualMapper.Mappers;
using AutoMapperXManualMapper.Models;
using BenchmarkDotNet.Attributes;

namespace AutoMapperXManualMapper;

[MemoryDiagnoser(displayGenColumns:false)]
public class MappingBenchmark
{
    private readonly IMapper _mapper;
    private readonly List<Pessoa> _pessoas;

    public MappingBenchmark()
    {
        MapperConfiguration config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        _mapper = config.CreateMapper();

        _pessoas = Enumerable.Range(0, 1000000)
            .Select(i => new Pessoa(i, "João", "Silva", "Desenvolvedor", DateTime.Now)).ToList();
    }

    [Benchmark]
    public List<PessoaDTO> AutoMapperMapping()
    {
        return _mapper.Map<List<PessoaDTO>>(_pessoas);
    }

    [Benchmark]
    public List<PessoaDTO> ManualMapping()
    {
        return _pessoas.Select(pessoa => pessoa.MapearParaDTO()).ToList();
    }
}
