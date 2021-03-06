using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public double Price { get; set; }
        public string Edition { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }

    }
}
