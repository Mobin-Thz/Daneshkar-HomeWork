using BookStore.Application.DTO;
using BookStore.Application.Services.Implementation;
using BookStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
namespace BookStore.API.Controllers
{

        [ApiController]
        [Route("api/[controller]/[action]")]
        public class BooksController : ControllerBase
        {
            private readonly BookServices _bookService;

            public BooksController(BookServices bookService)
            {
                _bookService = bookService;
            }

        [HttpPost]
        public async Task<ActionResult<BookDTO>> AddBook([FromBody] BookDTO book)
        {
            var result = await _bookService.AddBookAsync(book);

            // Object Mapping 
            var response = new BookDTO
            {
                Title = result.Title,
                Description = result.Description,
                Price = result.Price,
                Weight = result.Weight,
                Stock = result.Stock,
                AuthorId = result.AuthorId,
                CategoryId = result.CategoryId,
                PublisherId = result.PublisherId
            };

            return Ok(response);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] UpdateBookDTO updatedBook)
        {
            if (updatedBook == null)
                return BadRequest("Update data is required.");

            var updatedEntity = await _bookService.UpdateBookAsync(id, updatedBook);
            if (updatedEntity == null)
                return NotFound();

            return Ok(updatedEntity);
        }

        [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteBook(int id)
            {
                var success = await _bookService.DeleteBookAsync(id);
                if (!success) return NotFound();
                return NoContent();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetBookById(int id)
            {
                var book = await _bookService.GetBookByIdAsync(id);
                if (book == null) return NotFound();
                return Ok(book);
            }

            [HttpGet]
            public async Task<IActionResult> GetBookTitles(string title)
            {
            var book = await _bookService.GetBookByTitleAsync(title);
            if (book == null) return NotFound();
            return Ok(book);

            }

            [HttpGet("List")]
            public async Task<IActionResult> GetBooks([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
            {
                var paged = await _bookService.GetBooksPagedAsync(page, pageSize);
                return Ok(paged);
            }

    }
    
}
