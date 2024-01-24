using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Models.DB
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal? Rating { get; set; }

        [ForeignKey("Director")]
        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public virtual List<ActorMovie> ActorMovies { get; set; }
        public virtual List<GenreMovie> GenreMovies { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Award> Awards { get; set; }
    }
}
