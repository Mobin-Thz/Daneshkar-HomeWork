using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.DTO
{
    public class BookListItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public decimal Price { get; set; }
    }

}
