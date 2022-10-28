namespace Base.Shared.Dtos
{
    public class ApiResult
    {
        public string? Message { get; set; }
        public bool Status { get; set; }
        //public dynamic? Result { get; set; }


        //便捷创建ApiResult
        public static ApiResult<T> Ok<T>(T result, string? message = null)
        {
            return new ApiResult<T>()
            {
                Message = message,
                Result = result,
                Status = true
            };
        }
        public static ApiResult<T> OhNo<T>(string? message = null)
        {
            return new ApiResult<T>()
            {
                Message = message,
                Status = false
            };
        }
        public static ApiResult OhNo(string? message = null)
        {
            return new ApiResult()
            {
                Message = message,
                Status = false
            };
        }
        public static ApiResult Ok(string? message = null)
        {
            return new ApiResult()
            {
                Message = message,
                Status = true
            };
        }

    }
    public class ApiResult<T>
    {
        public string? Message { get; set; }
        public bool Status { get; set; }
        public T? Result { get; set; }
    }
}
