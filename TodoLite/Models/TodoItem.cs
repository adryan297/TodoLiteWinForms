namespace TodoLite.Models
{
    public sealed class TodoItem
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; init; } = DateTime.Now;
    }
}
