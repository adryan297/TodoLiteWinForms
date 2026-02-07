using TodoLite.Models;

namespace TodoLite.Repositories
{
    public interface ITodoRepository
    {
        IReadOnlyList<TodoItem> GetAll();
        void Add(string title);
        void ToggleDone(Guid id);
        void Remove(Guid id);
        void Save();
    }
}
