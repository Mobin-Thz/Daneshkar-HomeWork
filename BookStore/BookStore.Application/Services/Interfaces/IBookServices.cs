using BookStore.Application.DTO;
using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services.Interfaces
{
    public interface IBookServices
    {
        Task<Book?> GetBookByIdAsync(int id);
        Task<Book?> GetBookByTitleAsync(string Title);
        //List<Book> GetListOFBooksAsync(int page, int pageSize);

        Task<Book> AddBookAsync(BookDTO book);
        Task<Book> UpdateBookAsync(int id, UpdateBookDTO updatedBook);
        Task<bool> DeleteBookAsync(int id);
    }
}
