using Base.Shared.IServices;
using Testststs.Dtos.PoemDtos;

namespace Testststs.IServices
{
    public interface IPoemService : ICrudService<Int32, PoemDto,
       PoemUpdateDto, PoemCreateDto>
    {
        
    }
}