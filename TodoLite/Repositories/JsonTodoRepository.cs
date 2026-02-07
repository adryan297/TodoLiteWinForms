using System.Text.Json;
using TodoLite.Models;

namespace TodoLite.Repositories
{
    public sealed class JsonTodoRepository : ITodoRepository
    {
        private readonly string _filePath;
        private readonly List<TodoItem> _items;

        public JsonTodoRepository(string filePath)
        {
            _filePath = filePath;
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);
            _items = LoadInternal(_filePath);
        }

        public IReadOnlyList<TodoItem> GetAll() => _items;

        public void Add(string title)
        {
            title = (title ?? "").Trim();
            if (title.Length == 0) return;

            _items.Add(new TodoItem { Title = title });
        }

        public void ToggleDone(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item is null) return;
            item.IsDone = !item.IsDone;
        }

        public void Remove(Guid id)
        {
            var idx = _items.FindIndex(x => x.Id == id);
            if (idx >= 0) _items.RemoveAt(idx);
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(_items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        private static List<TodoItem> LoadInternal(string filePath)
        {
            if (!File.Exists(filePath)) return new List<TodoItem>();

            try
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<TodoItem>>(json) ?? new List<TodoItem>();
            }
            catch
            {
                // Kalau file rusak, jangan crash app.
                return new List<TodoItem>();
            }
        }
    }
}
