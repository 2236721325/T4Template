using Base.Shared.ClientShareds;
using Base.Shared.Dtos;
using HttpClientDemo.Dtos.PoemDtos;
using RestSharp;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace HttpClientDemo
{
    public class HelloSerch
    {
        public int SkipCount { get; set; }
        public int TakeCount { get; set; }
        public Dictionary<string,int>? Searchs { get; set; }
    }
    public class Search
    {
        public string Name { get; set; }
        public string Hello { get; set; }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            Dictionary<string, int> d = new Dictionary<string, int>();
            d["hello"] = 1;
            d["value"] = 2;
            BaseConfig.BaseUrl = "http://localhost:5007/";
            var search = new HelloSerch()
            {
                TakeCount = 100,
                SkipCount = 0,
                Searchs = d
            };
            //Dictionary<string, int> d = new Dictionary<string, int>();
            //d["hello"] = 1;
            //d["value"] = 2;
            Console.WriteLine(JsonSerializer.Serialize(d));
            Console.WriteLine(JsonSerializer.Serialize(search));

            var client = new RestClient("http://localhost:5007/");
            var request = new RestRequest("WeatherForecast/TestString");
            request.AddJsonBody(search);
            var response=client.Post(request);
            Console.WriteLine(response.ErrorMessage);
            
            
       
            //var result=await client
            //    .PostAsync<PagedSearchDto,PagedListDto<PoemDto>>(new PagedSearchDto()
            //    {
            //        SkipCount=0,
            //        TakeCount=10
            //    },"GetPagedList");

            //Console.WriteLine(JsonSerializer.Serialize(result, options));

            //var result1 = await client.GetAsync<int, PoemDto>(9);

            //Console.WriteLine(JsonSerializer.Serialize(result1,options));
            //var result2 = await client.PutAsync(new PoemUpdateDto()
            //{
            //    Content = "12222",
            //    Id = 9,
            //    Name = "jhahdadsd"
            //});
            //Console.WriteLine(JsonSerializer.Serialize(result2,options));
            //var result3 = await client.DeleteAsync(1);
            //Console.WriteLine(JsonSerializer.Serialize(result3,options));



        }
    }
}