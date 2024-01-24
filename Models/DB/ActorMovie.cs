using System.ComponentModel.DataAnnotations;

namespace Movie.Models.DB
{
    public class ActorMovie
    {
        [Key]
        public int ActorMovieId { get; set; }

        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
