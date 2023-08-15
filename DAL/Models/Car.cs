using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string ModelType { get; set; }
       
        public DateTime ModelYear { get; set; }
        public string? Power { get; set; }

        public virtual Brand Brand { get; set; }

        public AppUser? AppUser { get; set; }


    }
}
