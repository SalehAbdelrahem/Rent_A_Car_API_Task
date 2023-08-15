using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.BookingMasters
{
    public class BookingMasterDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CustomerDrivingLicenseNo { get; set; }
        public string Payment { get; set; }
        public string NationalityName { get; set; }
    }
}
