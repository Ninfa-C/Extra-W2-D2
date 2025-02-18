using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class BookshopController : Controller
    {
        private static List<Book> listbook = new List<Book>()
        {
            new Book("La casa sul mare celeste", "TJ Klune", "Fantasy", 17.00m, "https://www.ibs.it/images/9788804735144_0_0_0_0_0.jpg"),
            new Book("Harry Potter e la pietra filosofale", "J.K. Rowling", "Fantasy", 12.99m, "https://m.media-amazon.com/images/I/81YOuOGFCJL.jpg"),
            new Book("Frankenstein", "Mary Shelley", "Horror", 9.50m, "https://m.media-amazon.com/images/I/710p9SUfZtL._AC_UF1000,1000_QL80_.jpg"),
            new Book("Le cronache di Narnia: Il leone, la strega e l'armadio", "C.S. Lewis", "Fantasy", 14.99m, "https://clcitaly.com/_CLCItaly/images/products/original/2909.jpg"),
            new Book("Il mondo nuovo", "Aldous Huxley", "Distopia", 11.99m, "https://www.ibs.it/images/9788804735823_0_0_536_0_75.jpg"),
            new Book("I sette mariti di Evelyn Hugo", "Taylor Jenkins Reid", "Narrativa", 16.90m, "https://www.ibs.it/images/9788804740285_0_0_0_0_0.jpg"),
            new Book("Project Hail Mary", "Andy Weir", "Fantascienza", 18.99m, "https://m.media-amazon.com/images/I/51hvnrqNwHL._SL500_.jpg"),
            new Book("It Ends With Us", "Colleen Hoover", "Romanzo", 13.50m, "https://m.media-amazon.com/images/I/91CqNElQaKL.jpg"),
            new Book("La canzone di Achille", "Madeline Miller", "Storico", 14.90m, "https://m.media-amazon.com/images/I/71M6QkcIIOL._AC_UF1000,1000_QL80_.jpg"),
            new Book("Il codice da Vinci", "Dan Brown", "Thriller", 10.99m, "https://www.lafeltrinelli.it/images/9788804746676_0_0_536_0_75.jpg")
        };

        public IActionResult Index()
        {
            var BookList = new BookListModel()
            {
                Books = listbook
            };
            return View(BookList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddBook item)
         {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var formattedPrice = Math.Round(item.Price, 2);
            var newBook = new Book(item.Title!, item.Author!, item.Genre!, formattedPrice, item.Img!);

            listbook.Add(newBook);
            return RedirectToAction("Index");
        }
    }
}
