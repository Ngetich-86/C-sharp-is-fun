using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class ToDoService
    {
        private List<ToDoItem> _items = new List<ToDoItem>();

        public IEnumerable<ToDoItem> GetAll() => _items;

        public void Add(ToDoItem item) => _items.Add(item);

        public void MarkAsCompleted(int id)
        {
            var item = _items.Find(i => i.Id == id);
            if (item != null) item.IsCompleted = true;
        }
    }
}
