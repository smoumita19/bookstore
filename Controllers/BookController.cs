using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstConsoleApp.Repository;
using MyFirstConsoleApp.Models;

namespace MyFirstConsoleApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        {
            return View();
        }

        //returns all books in the application
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);

        }

        public BookModel GetBook(int id)
        {
            //return $"Book with id = {id}";
            return _bookRepository.GetBookById(id);
        }
    }
}
