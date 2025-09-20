using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BorrowingController : Controller
    {
        private readonly LibrarydbContext _context;

        public BorrowingController(LibrarydbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var borrowings = _context.Borrowings.ToList();
            return View(borrowings);
        }

        public IActionResult Borrow()
        {
            ViewBag.Books = _context.Books.Where(b => b.AvailableCopies > 0).ToList();
            ViewBag.Members = _context.Members.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Borrow(int bookId, int memberId)
        {
            var book = _context.Books.Find(bookId);
            var member = _context.Members.Find(memberId);

            if (book != null && member != null && book.AvailableCopies > 0)
            {
                book.AvailableCopies--;
                _context.Borrowings.Add(new Borrowing
                {
                    BookId = bookId,
                    MemberId = memberId,
                    BorrowDate = DateTime.Now
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Books = _context.Books.Where(b => b.AvailableCopies > 0).ToList();
            ViewBag.Members = _context.Members.ToList();
            ViewBag.Error = "Borrowing failed!";
            return View();
        }

        public IActionResult Return(int id)
        {
            var borrowing = _context.Borrowings.Find(id);
            if (borrowing != null && borrowing.ReturnDate == null)
            {
                borrowing.ReturnDate = DateTime.Now;
                var book = _context.Books.Find(borrowing.BookId);
                if (book != null)
                    book.AvailableCopies++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
