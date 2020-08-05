using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace DotnetApplication.Api
{
    public class TodoItemStore
    {
        private readonly List<TodoItem> todoList = new List<TodoItem>();

        public IEnumerable<TodoItem> GetItems() => todoList.ToArray();

        public void AddItem(TodoItem item)
        {
           item.Id = GetNextId();

           todoList.Add(item);
        }

        public bool ReplaceItem(int id, TodoItem item)
        {
            var existingItem = todoList.Find(x => x.Id == id);
            if (existingItem == null)
            {
                return false;
            }

            existingItem.Name = item.Name;
            existingItem.Description = item.Description;

            return true;
        }

        public bool DeleteItem(int id)
        {
            int index = todoList.FindIndex(x => x.Id == id);
            if (index < 0)
            {
                return false;
            }

            todoList.RemoveAt(index);

            return true;
        }

        private int GetNextId() =>
            todoList.Count == 0 ? 1 : todoList.Max(x => x.Id) + 1;
    }
}

