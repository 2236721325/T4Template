using AutoMapper;
using Base.Shared;
using Base.Shared.Dtos;
using Base.Shared.Services;
using T4Template.Datas;
using T4Template.Dtos.HelloDtos;
using T4Template.IServices;
using T4Template.Models;

namespace T4Template.Services
{
    public class HelloService : CrudService<Hello, Guid, 
        HelloDto, HelloUpdateDto, HelloCreateDto>,
        IHelloService,
        ITransientDependency
    {
        public HelloService(MyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<ApiResult> CanInsertAsync(HelloCreateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }

        public override async Task<ApiResult> CanUpdateAsync(HelloUpdateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }
    }
}