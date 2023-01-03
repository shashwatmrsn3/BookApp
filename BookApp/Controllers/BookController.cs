using Microsoft.AspNetCore.Mvc;
using BookApp.Models;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public void Create(BookModel bookModel)
        {
            Console.WriteLine(bookModel.Name);
            Console.WriteLine(bookModel.Author);
            Console.WriteLine(bookModel.ISBN);
          
        }


    }
}
