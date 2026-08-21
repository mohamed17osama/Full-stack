namespace Task_1.Models
{
    public class TaskFilterParam : PaginationParam
    {
        public string? Search { get; set; }

        public string? Status { get; set;}

        public bool? IsCompleted { get; set;}

        public string? SortBy { get; set; }

        public string? Order { get; set; } = "asc";



    }
}
