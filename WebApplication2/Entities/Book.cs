using System;
using System.Collections.Generic;

namespace WebApplication2.Entities
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? Price { get; set; }
        public string? Author { get; set; }
        public string? Lang { get; set; }
        public string? Publisher { get; set; }
    }
}
