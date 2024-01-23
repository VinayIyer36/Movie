using System.ComponentModel.DataAnnotations;

namespace Movie.Models.DB
{
    public class Award
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
