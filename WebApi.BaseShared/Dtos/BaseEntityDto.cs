using System.Security.Principal;

namespace WebApi.BaseShared.Dtos
{
    public class BaseEntityDto<TKey>
    {
        public TKey Id { get; set; }
    }
}
