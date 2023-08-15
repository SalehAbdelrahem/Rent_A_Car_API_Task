using Application.Contracts;
using DBContext;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.BookingDetails

{
    public class BookingDetailRepository : Repository<BookingDetail, int>, IBookingDetailRepository
    {
        public BookingDetailRepository(AppDBContext context) : base(context) { }
    }
}
