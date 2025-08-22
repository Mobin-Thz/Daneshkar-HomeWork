using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.DTO
{
    public class UpdateBookDTO
    {

        public string? Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public double? Weight { get; set; }


        public int? AuthorId { get; set; }

        public int? CategoryId { get; set; }

        public int? PublisherId { get; set; }

        public int? Stock { get; set; } = 0;

    }
}
