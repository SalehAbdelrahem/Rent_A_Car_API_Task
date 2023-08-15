using Application.Contracts;
using DBContext;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.BookingMasters
{
    public class BookingMasterRepository : Repository<Domain.BookingMaster, int>, IBookingMasterRepository

    {
        public BookingMasterRepository(AppDBContext context) : base(context) { }
    }
}
