using TodoLite.Repositories;
using TodoLite.Services;
using TodoLite.Models;

namespace TodoLite
{
    public partial class Form1 : Form
    {
        private readonly TodoService _service;

        public Form1()
        {
            InitializeComponent();

            var dataFile = Path.Combine(AppContext.BaseDirectory, "data", "todos.json");
            var repo = new JsonTodoRepository(dataFile);
            _service = new TodoService(repo);

            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _service.Add(txtTitle.Text);
            txtTitle.Clear();
            RefreshList();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (lstTodos.SelectedItem is TodoListItem selected)
            {
                _service.ToggleDone(selected.Id);
                RefreshList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTodos.SelectedItem is TodoListItem selected)
            {
                _service.Remove(selected.Id);
                RefreshList();
            }
        }

        private void RefreshList()
        {
            lstTodos.BeginUpdate();
            lstTodos.Items.Clear();

            foreach (var t in _service.GetAll())
                lstTodos.Items.Add(TodoListItem.From(t));

            lstTodos.EndUpdate();
        }

        private sealed class TodoListItem
        {
            public Guid Id { get; }
            private readonly string _display;

            private TodoListItem(Guid id, string display)
            {
                Id = id;
                _display = display;
            }

            public static TodoListItem From(TodoItem item)
            {
                var status = item.IsDone ? "[DONE]" : "[TODO]";
                var display = $"{status} {item.Title}";
                return new TodoListItem(item.Id, display);
            }

            public override string ToString() => _display;
        }
    }
}
