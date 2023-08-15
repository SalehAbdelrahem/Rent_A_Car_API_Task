using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BookingMaster
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CustomerDrivingLicenseNo { get; set; }
        public string Payment { get; set; }

        public virtual Nationality? Nationality { get; set; }

        public virtual ICollection<BookingDetail>? BookingDetails { get; set; }

    }
}
