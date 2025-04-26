using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        /* ────────── LIST ────────── */
        public IActionResult Index()
        {
            var entries = _db.DiaryEntries.ToList();
            return View(entries);
        }

        /* ────────── FORM (GET) ────────── */
        [HttpGet]
        public IActionResult Create()          // /DiaryEntries/Create  (GET)
        {
            return View();                     // shows Views/DiaryEntries/Create.cshtml
        }

        /* ────────── SAVE (POST) ────────── */
        [HttpPost, ValidateAntiForgeryToken]   // /DiaryEntries/Create  (POST)
        public IActionResult Create(DiaryEntry entry)
        {
            // basic validation
            if (entry != null && entry.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(entry);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(entry);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost, ValidateAntiForgeryToken]   // /DiaryEntries/Create  (POST)
        public IActionResult Edit(DiaryEntry entry)
        {
            // basic validation
            if (entry != null && entry.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(entry);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(entry);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost, ValidateAntiForgeryToken]   // /DiaryEntries/Create  (POST)
        public IActionResult Delete(DiaryEntry entry)
        {
                _db.DiaryEntries.Remove(entry);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
       
            return View(entry);
        }
    }
}
