namespace Base.Shared.Dtos
{
    public class PagedListDto<TEntityDto>
    {
        public List<TEntityDto> Items { get; set; }
        public long totalCount { get; set; }


        public PagedListDto(List<TEntityDto> items, long totalCount)
        {
            Items = items;
            this.totalCount = totalCount;
        }
    }
}
