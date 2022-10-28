using Base.Shared.IServices;
using TestWebApi.Dtos.PoemDtos;

namespace TestWebApi.IServices
{
    public interface IPoemService : ICrudService<Int32, PoemDto,
       PoemUpdateDto, PoemCreateDto>
    {
        
    }
}