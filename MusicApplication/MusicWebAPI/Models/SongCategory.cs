using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.UI.WebControls;

namespace MusicWebAPI.Models
{
    [Table("SongCategories")]
    public class SongCategory
    {
        [Key]
        public int ID { get; set; }

        public string DisplayName { get; set; }


        public List<Song> Songs { get; set; }
    }
}