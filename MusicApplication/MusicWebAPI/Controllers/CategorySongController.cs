using MusicWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWebAPI.Controllers
{
    public class CategorySongController : Controller
    {
        private readonly MusicDBContext db = new MusicDBContext();

        // GET: CategorySong
        public ActionResult Index()
        {
            return View(db.SongCategories.ToList());
        }

        [HttpPost]
        public ActionResult Create(string name)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && db.SongCategories.FirstOrDefault(c => c.DisplayName.ToUpper() == name.ToUpper().Trim()) == null)
            {
                var category = new SongCategory();

                category.DisplayName = name;

                db.SongCategories.Add(category);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(string name, int id)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name))
            {
                var category = db.SongCategories.FirstOrDefault(c => c.ID == id);

                category.DisplayName = name;

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = db.SongCategories.FirstOrDefault(c => c.ID == id);

            db.SongCategories.Remove(category);

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}