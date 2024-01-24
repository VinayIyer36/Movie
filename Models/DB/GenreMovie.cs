using System.ComponentModel.DataAnnotations;

namespace Movie.Models.DB
{
    public class GenreMovie
    {
        [Key]
        public int GenreMovieId { get; set; }
        public int GenreId { get; set; }
        public int MovieId { get; set; }
        public Genre Genre { get; set; }
        public Movie Movie { get; set; }
    }
}
