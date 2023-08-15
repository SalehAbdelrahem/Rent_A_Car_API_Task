using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car>? Cars { get; set; }
      
    }
}
