using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager1
{
    internal class TodoService
    {
        private readonly List<TodoItem> todos = new List<TodoItem>();
        private int nextId = 1;

        public List<TodoItem> GetAll()
        {
            return todos;
        }
        public TodoItem FindById(int id)
        {
            foreach (TodoItem todoItem in todos)
            {
                if (todoItem.Id == id)
                {
                    return todoItem;
                }
            }
            return null;
        }
        public void Add(string title, string description, DateTime dueDate)
        {
            TodoItem todoItem = new TodoItem(nextId, title, description, dueDate);
            todos.Add(todoItem);
            nextId++;
        }
        public void Completed(int id)
        {
            TodoItem todo = FindById(id);
            
            if(todo == null)
            {
                throw new ArgumentException("Няма задача с такова ID.");
            }
            todo.Completed();
        }
    }
}
