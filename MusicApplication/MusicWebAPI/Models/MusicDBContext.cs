using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicWebAPI.Models
{
    public class MusicDBContext : DbContext
    {
        public MusicDBContext() : base("MusicWebAPIConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<SongCategory> SongCategories { set; get; }
        public DbSet<Song> Songs { set; get; } 
         
    }
}