using GamesView.Data;
using GamesView.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesView.Controllers
{
    public class GamesController : Controller
    {

        private readonly GamesViewDbContext _db;

        public GamesController(GamesViewDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Games> objGamesList = _db.Gamess;
            return View(objGamesList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Games obj)
        {
            if(obj.GameName == obj.GameGenre)
            {
                ModelState.AddModelError("CustomError", "The game name cannot match the game genre");
            }
            if (ModelState.IsValid)
            {
                _db.Gamess.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }



        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Gamess.Find(id);
            //var categoryFromDbFirst = _db.Gamess.FirstOrDefault(u=>u.GameId==id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Games obj)
        {
            if (obj.GameName == obj.GameGenre)
            {
                ModelState.AddModelError("CustomError", "The game name cannot match the game genre");
            }
            if (ModelState.IsValid)
            {
                _db.Gamess.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Game updated successfully!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Gamess.Find(id);
            //var categoryFromDbFirst = _db.Gamess.FirstOrDefault(u=>u.GameId==id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Gamess.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Gamess.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Game deleted successfully!";
            return RedirectToAction("Index");
        }

    }
}
