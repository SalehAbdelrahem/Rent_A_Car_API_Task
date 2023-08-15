using Application.Contracts.Cars;
using DBContext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Net;

namespace InfraStructure.Cars
{
    public class CarRepository : Repository<Car, int>, ICarRepository
    {
        public CarRepository(AppDBContext context) : base(context) { }

        public async Task<IEnumerable<Car>> FilterByAsync(string? modelName = null, string? brandName = null, DateTime? date = null)
        {
            var cars=_context.Cars.Include(b=>b.Brand);
            if (cars is null)
            {
                throw new Exception("Not Found Any Cars");
            }
            else
            {
             
                return await  _context.Cars.Include(x => x.Brand)
                .Where(a => modelName == null ? true : a.ModelName.ToLower().Contains(modelName.ToLower()))
                .Where(a =>brandName == null ? true : a.Brand.Name.ToLower().Contains(brandName.ToLower()))
                .Where(a => date == null ? true : a.ModelYear.Equals(date)).ToListAsync();

            }
           
        }

      

        public async Task<IEnumerable<Car>> GetCarsByBrandIdAsync(int id)
        {
           return await _context.Cars.Include(x=>x.Brand).Where(x => x.Brand.Id == id).ToListAsync();
        }
    }
}