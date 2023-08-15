using DTOs.BookingDetails;
using DTOs.BookingMasters;
using DTOs.MasterDetails;
using MediatR;

namespace Application.Features.MasterDetails.Commands.CreateMasterDetail
{
    public class CreateMasterDetailCommand : IRequest<MasterDetailDTO>
    {
        //master
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CustomerDrivingLicenseNo { get; set; }
        public string Payment { get; set; }
        public int NationalityId { get; set; }

        public List<BookingDetailDTO> BookingDetailDTO { get; set; }
    }
}
