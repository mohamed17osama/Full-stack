namespace Assignment5.Models
{
    public class TaskFilterParams : PaginationParam
    {
        public string? Search {  get; set; }
        
        public int? Workers { get; set; }

        public bool? Iscompleted { get; set; }

        public string? SortBy { get; set; }

        public string? Order { get; set; } = "asc";

    }
}
