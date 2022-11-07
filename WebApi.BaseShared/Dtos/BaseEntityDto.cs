using System.Security.Principal;

namespace Base.Shared.Dtos
{
    public class BaseEntityDto<TKey>
    {
        public TKey Id { get; set; }
    }
}
