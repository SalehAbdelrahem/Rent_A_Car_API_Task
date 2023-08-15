namespace Domain
{
    public class Nationality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookingMaster>? BokingMaster { get; set; }
    }
}
