namespace DAL.Models
{
    public class BookingDetail
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int Quantity { get; set; }
        public string RentDuration { get; set; }

        public virtual BokingMaster bokingMaster { get; set; }

    }
}
