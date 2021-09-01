using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookShelf { get; set; }
        public List<Yazar> Yazarlar { get; set; }

    }

    
}
