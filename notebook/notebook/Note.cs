using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    internal class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Note(string title, string description, DateTime date)
        {
            Title = title;
            Description = description;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Title}\n----------------------------------------------------\nОписание: {Description}\nДата: {Date.ToShortDateString()}";
        }
    }
}
