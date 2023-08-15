using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car>? Cars { get; set; }

    }
}
