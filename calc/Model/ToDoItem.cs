using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Model
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsImportant { get; set; }

        public ToDoItem(int id, string title, string content, DateTime date, bool isCompleted, bool isImportant)
        {
            Id = id;
            Title = title;
            Content = content;
            Date = date;
            IsCompleted = isCompleted;
            IsImportant = isImportant;
        }
    }

}
