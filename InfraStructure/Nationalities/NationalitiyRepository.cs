using Application.Contracts.Nationalities;
using DBContext;
using Domain;

namespace InfraStructure.Nationalities
{
    public class NationalitiyRepository : Repository<Nationality, int>, INationalitiyRepository
    {
        public NationalitiyRepository(AppDBContext context) : base(context) { }
    }
}
