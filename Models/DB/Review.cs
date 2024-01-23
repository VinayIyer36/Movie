using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Models.DB
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(5000)]
        public string Text { get; set; }
        public int? Rating { get; set; }

        [Required]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
