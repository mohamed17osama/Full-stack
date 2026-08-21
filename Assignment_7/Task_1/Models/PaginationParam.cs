namespace Task_1.Models
{
    public class PaginationParam
    {
        private const int _maxPageSize = 100;

        private int _PageSize = 20;

        public int Page { get; set; } = 1;

        public int pageSize 
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value > _maxPageSize ? _maxPageSize : value;
            } 
        }
    }
}
