using Base.Shared.IServices;
using T4Template.Dtos.HelloDtos;

namespace T4Template.IServices
{
    public interface IHelloService : ICrudService<Guid, HelloDto,
       HelloUpdateDto, HelloCreateDto>
    {
        
    }
}