using System.ComponentModel.DataAnnotations;

namespace Movie.Models.DB
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ActorMovie> ActorMovies { get; set; }
    }
}
