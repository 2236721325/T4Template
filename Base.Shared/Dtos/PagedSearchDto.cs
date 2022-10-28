using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Base.Shared.Dtos
{
    public class PagedSearchDto
    {
        public int SkipCount { get; set; }
        public int TakeCount { get; set; }
        public Dictionary<string, JsonElement>? Searchs { get; set; }
    }
}
