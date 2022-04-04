using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookstoreController : ControllerBase
    {
        [HttpGet]
        [Route("BooksController")]
        [ActionName("GetAllBooks")]
        public IEnumerable<Book> GetAllBooks()
        {
            return BooksManager.Books.OrderBy(book => book.Id);
        }

        [HttpGet]
        [Route("BooksByYearController")]
        [ActionName("GetAllBooksByYear")]
        public IEnumerable<Book> GetAllBooks(int year)
        {
            return BooksManager.Books.Where(book => book.PublicationDate.Year == year);
        }

        [HttpPost]
        [Route("AddBookController")]
        [ActionName("AddBook")]
        public ActionResult AddNewBook(Book book)
        {
            BooksManager.Books.Add(book);
            return Ok(book);
        }

        [HttpPut]
        [Route("UpdateBookByIdController")]
        [ActionName("UpdateBookById")]
        public ActionResult UpdateBook(Book book)
        {
            try
            {
                var bookToUpdate = BooksManager.Books.First(b => b.Id == book.Id);
                BooksManager.Books.Remove(bookToUpdate);
                BooksManager.Books.Add(book);
            }
            catch
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpDelete]
        [Route("DeleteBookByIdController")]
        [ActionName("DeleteBookById")]
        public ActionResult DeleteBook(int id)
        {
            Book bookToDelete = null;
            try
            {
                bookToDelete = BooksManager.Books.First(b => b.Id == id);
                BooksManager.Books.Remove(bookToDelete);
            }
            catch
            {
                return NotFound();
            }

            return Ok(bookToDelete);
        }
    }
}
