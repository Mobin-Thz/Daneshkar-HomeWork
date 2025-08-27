using BookStore.Application.DTO;
using BookStore.Application.Services.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Domain.RepositoryInterfaces;
using BookStore.Domain.ValueObjects;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services.Implementation
{
    public class BookServices(IBookRepository context) : IBookServices
    {

            private readonly IBookRepository _repository=context;

            public async Task<Book> AddBookAsync(BookDTO model)
            {
                var existingBook = await _repository.GetBookByTitle(model.Title);
                if (existingBook != null)
                {
                    existingBook.Stock += 1;
                    await _repository.UpdateBook(existingBook);
                    return existingBook;
                }

                #region Object Mappingfn,

                Book book = new Book();

                book.Title = model.Title;
                book.Description = model.Description;
                book.Price = model.Price;
                book.Weight = model.Weight;
                book.AuthorId = model.AuthorId;
                book.CategoryId = model.CategoryId;
                book.PublisherId = model.PublisherId;
                book.Stock = model.Stock;

                #endregion

                book.Stock = 1;
                await _repository.AddBook(book);
                return book;
            }


            public async Task<Book> UpdateBookAsync(int id, UpdateBookDTO updatedBook)
            {
                var existing = await _repository.GetBookById(id);
                if (existing == null) return null;

                if (!string.IsNullOrEmpty(updatedBook.Title)) existing.Title = updatedBook.Title;
                if (!string.IsNullOrEmpty(updatedBook.Description)) existing.Description = updatedBook.Description;
                if (updatedBook.Price.HasValue) existing.Price = updatedBook.Price.Value;
                if (updatedBook.Weight.HasValue) existing.Weight = updatedBook.Weight.Value;
                if (updatedBook.Stock.HasValue) existing.Stock = updatedBook.Stock.Value;
                if (updatedBook.AuthorId.HasValue) existing.AuthorId = updatedBook.AuthorId.Value;
                if (updatedBook.CategoryId.HasValue) existing.CategoryId = updatedBook.CategoryId.Value;
                if (updatedBook.PublisherId.HasValue) existing.PublisherId = updatedBook.PublisherId.Value;

                await _repository.UpdateBook(existing);
                return existing;
            }

        public async Task<bool> DeleteBookAsync(int id)
            {
                var book = await _repository.GetBookById(id);
                if (book == null) return false;

                await _repository.DeleteBook(book);
                return true;
            }

            public async Task<Book?> GetBookByIdAsync(int id)
            {
                return await _repository.GetBookById(id);
            }

            public async Task<Book> GetBookByTitleAsync(string title)
            {
                return await _repository.GetBookByTitle(title);
            }

        public async Task<PagedResult<BookListItemDTO>> GetBooksPagedAsync(int page, int pageSize)
        {
            var result = await _repository.GetBooksPagedAsync(page, pageSize);

            var dtoItems = result.Items.Select(b => new BookListItemDTO
            {
                Id = b.Id,
                Title = b.Title,
                Price = b.Price
            }).ToList();

            return new PagedResult<BookListItemDTO>
            {
                Items = dtoItems,
                Page = result.Page,
                PageSize = result.PageSize,
                TotalCount = result.TotalCount
            };


        }


    }
}
