namespace Assignment_6.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        // Foreign key
        public int UserId { get; set; }

        // Navigation property

        public User? User { get; set; }
    }
}
