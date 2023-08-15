using Domain;

namespace Application.Contracts.Cars
{
    public interface ICarRepository : IRepository<Car, int>
    {
        Task<IEnumerable<Car>> FilterByAsync(string? modelName = null, string? brandName = null, DateTime? date=null);
        Task<IEnumerable<Car>> GetCarsByBrandIdAsync(int id);

    }
}
