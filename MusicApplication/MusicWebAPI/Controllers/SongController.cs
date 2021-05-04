using MusicWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MusicWebAPI.Controllers
{
    public class SongController : Controller
    {
        private readonly MusicDBContext db = new MusicDBContext();



        Random rand = new Random();

        // GET: Song
        public ActionResult Index()
        {

            return View(db.Songs.ToList().OrderByDescending(s=>s.ViewCount).ToList());
        }

        [HttpPost]
        public ActionResult Creates(string id, string name, string title, string code, string artists_names, string performer, string thumbnail, int duration, string lyricLink, int total, string url)
        {
            // Lấy  danh sách CategoryID đưa vào List

            List<int> categoryIDList = categoryIDList = db.SongCategories.Select(c => c.ID).ToList(); 
            int countID = categoryIDList.Count;

            try
            {
                var song = new Song();

                song.IDZing = id;
                song.DisplayName = name;
                song.Title = title;
                song.Code = code;
                song.ArtistsNames = artists_names;
                song.Performer = performer;
                song.Thumbnail = thumbnail;
                song.Duration = duration;
                song.Lyric = lyricLink;
                song.ViewCount = total;
                song.URL = url;
                song.CategorySongID = categoryIDList[rand.Next(0, countID)];

                db.Songs.Add(song);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Content("0");
            }

            return Content("1");
        }

        [HttpPost]
        public ActionResult DeleteAll()
        {
            try
            {
                db.Songs.RemoveRange(db.Songs);
                db.SaveChanges();
                return Content("1");
            }
            catch (Exception)
            {

                return Content("0");
            }

        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            ViewBag.SongCategory = new List<SelectListItem>();
            List<SelectListItem> items = new List<SelectListItem>();

            items.AddRange(db.SongCategories.ToList().Select(s => new SelectListItem() { Text = s.DisplayName, Value = s.ID.ToString() }));

            ViewBag.items = items;

            return View(db.Songs.FirstOrDefault(s => s.ID == id));
        }

        [HttpPost]
        public ActionResult Update(Song model)
        {
            try
            {
                var song = db.Songs.FirstOrDefault(s => s.ID == model.ID);

                song.IDZing = model.IDZing;
                song.CategorySongID = model.CategorySongID;
                song.DisplayName = model.DisplayName;
                song.Title = model.Title;
                song.Code = model.Code;
                song.ArtistsNames = model.ArtistsNames;
                song.Performer = model.Performer;
                song.Lyric = model.Lyric;
                song.Thumbnail = model.Thumbnail;
                song.Duration = model.Duration;
                song.ViewCount = model.ViewCount;
                song.URL = model.URL;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.SongCategory = new List<SelectListItem>();

            List<SelectListItem> items = new List<SelectListItem>();

            items.AddRange(db.SongCategories.ToList().Select(s => new SelectListItem() { Text = s.DisplayName, Value = s.ID.ToString() }));

            ViewBag.items = items;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Song model)
        {
            try
            {
                db.Songs.Add(model);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                var song = db.Songs.FirstOrDefault(s => s.ID == id);

                db.Songs.Remove(song);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
            }

            return RedirectToAction("Index");
        }
    }
}