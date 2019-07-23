using System;

namespace Tasks.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Task(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}