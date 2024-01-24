using System.ComponentModel.DataAnnotations;

namespace Movie.Models.DB
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<GenreMovie> GenreMovies { get; set; }
    }
}
