using Application.Contracts;
using DBContext;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure
{
    public class BrandRepository : Repository<Brand, int>, IBrandRepository
    {
        public BrandRepository(AppDBContext context) : base(context) { }

        public async Task<IEnumerable<Brand>> FilterByAsync(string? filter = null)
        {
            return _context.Brands.Where(a => filter == null || a.Name.ToLower().Contains(filter.ToLower()));

        }

        public override async Task<Brand?> GetDetailsAsync(int id)
        {
            return _context.Brands.Where(a => a.Id == id).Include(a => a.Cars).FirstOrDefault();
        }

    }
}
