namespace Domain
{
    public class BookingDetail
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int Quantity { get; set; }
        public DateTime RentDuration { get; set; }

        public virtual BookingMaster BookingMaster { get; set; }

    }
}
