using FreeSql.DataAnnotations;

namespace WebApi.FreeSqlShared.Domains
{
    public class BaseEntity<TKey>
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public TKey Id { get; set; }
    }
}
