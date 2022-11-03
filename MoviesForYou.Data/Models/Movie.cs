using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesForYou.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public MovieGenreEnum? Genre { get; set; }

        public List<Keyword> Keywords { get; set; } = new List<Keyword>();

    }
}
