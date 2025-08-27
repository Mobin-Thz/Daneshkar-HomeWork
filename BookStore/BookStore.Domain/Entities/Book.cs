using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }   

        public double? Weight { get; set; }

        public int Stock { get; set; } = 0;


        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public int PublisherId { get; set; }

    }
}
