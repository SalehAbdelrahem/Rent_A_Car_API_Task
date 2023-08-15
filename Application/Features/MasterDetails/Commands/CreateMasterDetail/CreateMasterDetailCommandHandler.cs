using Application.Contracts;
using Application.Contracts.Nationalities;
using Domain;
using DTOs.BookingDetails;
using DTOs.MasterDetails;
using MediatR;

namespace Application.Features.MasterDetails.Commands.CreateMasterDetail
{
    public class CreateMasterDetailCommandHandler : IRequestHandler<CreateMasterDetailCommand, MasterDetailDTO>
    {
        private readonly IBookingMasterRepository _bookingMasterRepository;
        private readonly INationalitiyRepository _nationalitiyRepository;
        private readonly IBookingDetailRepository _bookingDetailRepository;
       

        public CreateMasterDetailCommandHandler(IBookingMasterRepository bookingMasterRepository,
            IBookingDetailRepository bookingDetailRepository,
            INationalitiyRepository nationalitiyRepository
            )
        {
            _bookingMasterRepository = bookingMasterRepository;
            _nationalitiyRepository = nationalitiyRepository;
            _bookingDetailRepository = bookingDetailRepository;
        }
        public async Task<MasterDetailDTO> Handle(CreateMasterDetailCommand request, CancellationToken cancellationToken)
        {
            return await CreateMasterDerailOrder(request);

        }

        private async Task<MasterDetailDTO> CreateMasterDerailOrder(CreateMasterDetailCommand request)
        {
            try
            {
                var nationality = await _nationalitiyRepository.GetDetailsAsync(request.NationalityId);
                if (nationality is null)
                {
                    throw new Exception("Not Valid Nationality");
                }
                else
                {
                    var BookingMasterTemp = new BookingMaster()
                    {
                        
                        CustomerName = request.CustomerName,
                        Payment = request.Payment,
                        TransactionDate = request.TransactionDate,
                        CustomerDrivingLicenseNo = request.CustomerDrivingLicenseNo,
                        Nationality=nationality
                      
                    };

                    await _bookingMasterRepository.CreateAsync(BookingMasterTemp);

                    foreach (var item in request.BookingDetailDTO)
                    {
                        var temp = new BookingDetail()
                        {
                            CarName = item.CarName,
                            Quantity = item.Quantity,
                            RentDuration = item.RentDuration,
                            BookingMaster=BookingMasterTemp
                        };
                       
                        var BookingDetailTemp = await _bookingDetailRepository.CreateAsync(temp);
                        if (BookingDetailTemp is not null)
                        {
                            BookingMasterTemp.BookingDetails.Add(BookingDetailTemp);
                        }

                    }
                    await _bookingMasterRepository.UpdateAsync(BookingMasterTemp);

                    return new MasterDetailDTO()
                    {
                        Id = BookingMasterTemp.Id,
                        BookingMasterDTO = new DTOs.BookingMasters.BookingMasterDTO()
                        {
                            Id = BookingMasterTemp.Id,
                            CustomerName = BookingMasterTemp.CustomerName,
                            Payment = BookingMasterTemp.Payment,
                            CustomerDrivingLicenseNo = BookingMasterTemp.CustomerDrivingLicenseNo,
                            NationalityName = BookingMasterTemp.Nationality.Name,
                            TransactionDate = BookingMasterTemp.TransactionDate
                        },
                        BookingDetailDTO = BookingMasterTemp.BookingDetails.Select(x => new BookingDetailDTO()
                        {
                            Id = x.Id,
                            CarName = x.CarName,
                            Quantity = x.Quantity,
                            RentDuration = x.RentDuration
                        }).ToList()
                    };
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
