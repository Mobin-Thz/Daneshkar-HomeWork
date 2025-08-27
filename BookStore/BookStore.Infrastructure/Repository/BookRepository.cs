using BookStore.Domain.Entities;
using BookStore.Domain.RepositoryInterfaces;
using BookStore.Domain.ValueObjects;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Repository
{


    public class BookRepository(BookStoreDbContext context) : IBookRepository
    {

        private readonly BookStoreDbContext _context = context;



        public Task<Book> GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefaultAsync(p => p.Id == bookId);
        }
        public Task<Book> GetBookByTitle(string bookTitle)
        {
            return _context.Books.FirstOrDefaultAsync(p => p.Title == bookTitle);
        }

        public List<Book> GetListOFBooks()
        {
            return _context.Books.ToList();
        }

        public async Task AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBook(Book model)
        {
            _context.Books.Update(model);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }


        public async Task<PagedResult<Book>> GetBooksPagedAsync(int page, int pageSize)
        {
            if (page < 1) page = 1;
            if (pageSize <= 0) pageSize = 10;

            var query = _context.Books.AsNoTracking().OrderBy(b => b.Id);

            var total = await query.CountAsync();
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Book>
            {
                Items = items,
                Page = page,
                PageSize = pageSize,
                TotalCount = total
            };


        }

    }
}
