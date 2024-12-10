using AutoMapper;
using AutoMapperXManualMapper.Models;

namespace AutoMapperXManualMapper.Mappers;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Pessoa, PessoaDTO>()
            .ForMember(dest => dest.CreatedAt,
                opt => opt.MapFrom
                (
                    src => src.CreatedAt.ToString("dd/MM/yyyy")
                )
            );
    }
}
