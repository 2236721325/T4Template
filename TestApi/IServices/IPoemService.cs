using Base.Shared.IServices;
using TestApi.Dtos.PoemDtos;

namespace TestApi.IServices
{
    public interface IPoemService : ICrudService<Int32, PoemDto,
       PoemUpdateDto, PoemCreateDto>
    {
        
    }
}