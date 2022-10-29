using Base.Shared.ClientShareds;
using Base.Shared.Dtos;
using HttpClientDemo.Dtos.PoemDtos;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace HttpClientDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };

            BaseConfig.BaseUrl = "http://localhost:5222/api/";



            var client = new BaseRequest("Poem");

            var result=await client
                .PostAsync<PagedSearchDto,PagedListDto<PoemDto>>(new PagedSearchDto()
                {
                    SkipCount=0,
                    TakeCount=10
                },"GetPagedList");

            Console.WriteLine(JsonSerializer.Serialize(result, options));

            var result1 = await client.GetAsync<int, PoemDto>(9);

            Console.WriteLine(JsonSerializer.Serialize(result1,options));
            var result2 = await client.PutAsync(new PoemUpdateDto()
            {
                Content = "12222",
                Id = 9,
                Name = "jhahdadsd"
            });
            Console.WriteLine(JsonSerializer.Serialize(result2,options));
            var result3 = await client.DeleteAsync(1);
            Console.WriteLine(JsonSerializer.Serialize(result3,options));



        }
    }
}