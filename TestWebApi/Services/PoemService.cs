using AutoMapper;
using Base.Shared;
using Base.Shared.Dtos;
using Base.Shared.Services;
using TestWebApi.Datas;
using TestWebApi.Dtos.PoemDtos;
using TestWebApi.IServices;
using TestWebApi.Models;

namespace TestWebApi.Services
{
    public class PoemService : CrudService<Poem, Int32, 
        PoemDto, PoemUpdateDto, PoemCreateDto>,
        IPoemService,
        ITransientDependency
    {
        public PoemService(MyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<ApiResult> CanInsertAsync(PoemCreateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }

        public override async Task<ApiResult> CanUpdateAsync(PoemUpdateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }
    }
}