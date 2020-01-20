using System;
using System.Collections.Generic;
using System.Text;

namespace ME.dll.Models.BookInventory
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<String> CoAuthors { get; set; }
        public bool HasRead { get; set; }
    }
}
