using System.Reflection;

namespace Task_1.DTOs
{
    public class UpdateTaskRequestDTO
    {
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public string Status { get; set; }

    }
}
