namespace DAL.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual BokingMaster? BokingMaster { get; set; }
    }
}
