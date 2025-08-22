using BookStore.Domain.Entities;
using BookStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.RepositoryInterfaces
{
    public interface IBookRepository
    {
        Task<Book?> GetBookById(int id);
        List<Book> GetListOFBooks();
        Task<Book> GetBookByTitle(string bookTitle);

        Task AddBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(Book book);
        Task<PagedResult<Book>> GetBooksPagedAsync(int page, int pageSize);

    }
}
