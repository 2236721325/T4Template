using FreeSql.DataAnnotations;

namespace Base.Shared.Domains
{
    public class BaseEntity<TKey>
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public TKey Id { get; set; }
    }
}
