namespace WebApi.EFShared.Domains
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
