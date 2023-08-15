using DTOs.BookingDetails;
using DTOs.BookingMasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.MasterDetails
{
    public class MasterDetailDTO
    {
        public int Id { get; set; }
        public BookingMasterDTO BookingMasterDTO { get; set; }
        public List<BookingDetailDTO> BookingDetailDTO { get; set; }
    }
}
