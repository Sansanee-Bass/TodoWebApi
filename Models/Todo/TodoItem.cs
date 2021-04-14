using System;

namespace TodoWebAPI.Models.Todo
{

    public class TodoItem
    {
        public uint TodoItemId { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
        public Person Responsible { get; set; }

        public DateTime DateTime { get; set; }

        // public virtual Person Resposible { get; set; }
    }
}