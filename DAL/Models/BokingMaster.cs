namespace DAL.Models
{
    public class BokingMaster
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CustomerDrivingLicenseNo { get; set; }
        public string Payment { get; set; }
        public Nationality Nationality { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

    }
}
