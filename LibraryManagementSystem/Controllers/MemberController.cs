using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class MemberController : Controller
    {
        private readonly LibrarydbContext _context;

        public MemberController(LibrarydbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Members.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                _context.Members.Add(member);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(member);
        }


        public IActionResult Edit(int id)
        {
            var member = _context.Members.Find(id);
            if (member == null)
                return NotFound();
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                _context.Members.Update(member);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(member);
        }

        public IActionResult Delete(int id)
        {
            var member = _context.Members.Find(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

