using MusicWebAPI.Models;
using MusicWebAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MusicWebAPI.Controllers
{
    public class MusicAPIController : ApiController
    {
        private readonly MusicDBContext db = new MusicDBContext();

        [Route("Api/MusicAPIController/SayHello")]
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult SayHello()
        {
            return Ok("Hello");
        }

        [Route("Api/MusicAPIController/GetCategories")]
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GetCategories()
        {
            return Ok(db.SongCategories.ToList());
        }

        [Route("Api/MusicAPIController/GetSongs")]
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GetSongs()
        {
            return Ok(db.Songs.ToList().OrderByDescending(s => s.ViewCount).ToList());
        }

        [Route("Api/MusicAPIController/Delete/{id}")]
        [AllowAnonymous]
        [HttpGet]
        public int Delete(int id)
        {
            try
            {
                var song = db.Songs.FirstOrDefault(s => s.ID == id);
                db.Songs.Remove(song);

                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;   
            }
        }

        [Route("Api/MusicAPIController/Create")]
        [AllowAnonymous]
        [HttpPost]
        public int Create(Song song)
        {
            try
            {
                db.Songs.Add(song);
                db.SaveChanges();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        [Route("Api/MusicAPIController/Update")]
        [AllowAnonymous]
        [HttpPost]
        public int Update(Song song)
        {
            try
            {
                var s = db.Songs.FirstOrDefault(sg => sg.ID == song.ID);
                s.DisplayName = song.DisplayName;
                s.CategorySongID = song.CategorySongID;
                s.Title = song.Title;
                s.ArtistsNames = song.ArtistsNames;
                s.Performer = song.Performer;
                s.Lyric = song.Lyric;
                s.URL = song.URL;
                s.Thumbnail = song.Thumbnail;
                s.Duration = song.Duration;

                db.SaveChanges();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        [Route("Api/MusicAPIController/UploadFile")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<int> UploadFile()
        {
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/Assets/Images");
            var provider = new MultipartFormDataStreamProvider(root); 

            try
            {
                await Request.Content.ReadAsMultipartAsync(provider);

                foreach (var file in provider.FileData)
                {
                    var name = file.Headers.ContentDisposition.FileName;

                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);

                    File.Move(localFileName, filePath);
                }

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            } 
        }
    }
}
