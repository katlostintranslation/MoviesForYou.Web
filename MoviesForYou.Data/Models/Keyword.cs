using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesForYou.Data.Models
{
    public class Keyword
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Value { get; set; }

        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}
