using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicWebAPI.Models
{
    [Table("Songs")]
    public class Song
    {
        [Key]
        public int ID { get; set; }             // id

        public  string IDZing { get; set; }

        [ForeignKey("SongCategory")]
        public int CategorySongID { get; set; }

        public string DisplayName { get; set; } // name

        public string Title { get; set; }   // title

        public string Code { get; set; }    // code

        public string ArtistsNames { get; set; }    // artists_names

        public string Performer { get; set; }   // performer

        public string Lyric { get; set; }   // lyric    là một link tới web

        public string Thumbnail { get; set; }   // album?.thumbnail_medium??thumbnail   cũng là  link

        public int Duration { get; set; } // duration

        public int ViewCount { get; set; }  // total

        public string URL { get; set; }         // nhập tay

        public SongCategory SongCategory { get; set; }
    }
}