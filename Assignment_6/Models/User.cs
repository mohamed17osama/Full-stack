namespace Assignment_6.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<TaskItem> TaskItem { get; set; } = new List<TaskItem>();

    }
}
