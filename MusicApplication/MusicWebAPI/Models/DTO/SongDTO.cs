using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicWebAPI.Models.DTO
{
    public class SongDTO
    {
        public string IDZing { get; set; }

        public int CategorySongID { get; set; }

        public string DisplayName { get; set; } 

        public string Title { get; set; } 

        public string Code { get; set; }  

        public string ArtistsNames { get; set; }  

        public string Performer { get; set; }  

        public string Lyric { get; set; }  

        public string Thumbnail { get; set; } 

        public int Duration { get; set; }

        public int ViewCount { get; set; } 

        public string URL { get; set; }

        public byte[] ThumbnailBytes { get; set; }
    }
}