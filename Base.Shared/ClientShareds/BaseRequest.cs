using Base.Shared.Dtos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Shared.ClientShareds
{
    public class BaseRequest
    {
        private readonly RestClient _Client;

        public BaseRequest(string groupName)
        {
            _Client = new RestClient(BaseConfig.BaseUrl + groupName);
        }
        public async Task<ApiResult<TDto>> GetAsync<TId, TDto>(TId id, string methodName = "Get")
        {
            var request = new RestRequest($"{methodName}/{id}", Method.Get);
            var response = await _Client.ExecuteAsync<ApiResult<TDto>>(request);
            if (!response.IsSuccessful)
            {
                return ApiResult.OhNo<TDto>(response.ErrorMessage);
            }
            return response.Data;
        }

        public async Task<ApiResult<TDto>> PostAsync<TBody, TDto>(TBody body, string methodName) where TBody : class
        {
            var request = new RestRequest($"{methodName}", Method.Post);
            request.AddJsonBody(body);
            var response =await _Client.ExecuteAsync<ApiResult<TDto>>(request);
            if (!response.IsSuccessful)
            {
                return ApiResult.OhNo<TDto>(response.ErrorMessage);
            }
            return response.Data;
        }
        public async Task<ApiResult> PutAsync<TBody>(TBody body, string methodName="Update") where TBody : class
        {
            var request = new RestRequest($"{methodName}", Method.Put);
            request.AddJsonBody(body);
            var response =await _Client.ExecuteAsync<ApiResult>(request);
            if (!response.IsSuccessful)
            {
                return ApiResult.OhNo(response.ErrorMessage);
            }
            return response.Data;
        }
        public async Task<ApiResult> DeleteAsync<TId>(TId id, string methodName = "Delete")
        {
            var request = new RestRequest($"{methodName}/{id}", Method.Delete);
            var response = await _Client.ExecuteAsync<ApiResult>(request);
            if (!response.IsSuccessful)
            {
                return ApiResult.OhNo(response.ErrorMessage);
            }
            return response.Data;
        }
    }

}
