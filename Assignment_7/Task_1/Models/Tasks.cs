using System.ComponentModel.DataAnnotations;

namespace Task_1.Models
{
    public class Tasks
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Status { get; set; }

        //public bool IsCompleted { get; set; }

        public DateTime? CreatedAt { get; set; }


    }
}
