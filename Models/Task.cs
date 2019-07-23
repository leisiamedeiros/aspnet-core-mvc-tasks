using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public Task() { }

        public Task(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}