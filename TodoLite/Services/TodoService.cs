using TodoLite.Models;
using TodoLite.Repositories;

namespace TodoLite.Services
{
    public sealed class TodoService
    {
        private readonly ITodoRepository _repo;

        public TodoService(ITodoRepository repo) => _repo = repo;

        public IReadOnlyList<TodoItem> GetAll() => _repo.GetAll();

        public void Add(string title)
        {
            _repo.Add(title);
            _repo.Save();
        }

        public void ToggleDone(Guid id)
        {
            _repo.ToggleDone(id);
            _repo.Save();
        }

        public void Remove(Guid id)
        {
            _repo.Remove(id);
            _repo.Save();
        }
    }
}
