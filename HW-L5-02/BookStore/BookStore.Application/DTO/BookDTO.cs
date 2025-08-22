using BookStore.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Application.DTO
{
    public class BookDTO
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public double? Weight { get; set; }


        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public int PublisherId { get; set; }

        public int Stock { get; set; } = 0;



    }
}
