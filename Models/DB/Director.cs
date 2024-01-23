using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Models.DB
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
