using BLL.DTOs;
using DAL.Models;
using Repositories.Contacts;

namespace BLL.Services
{
    public class ServicesBrand
    {
        public readonly IRepository<Brand , int> _repository;
        public ServicesBrand(IRepository<Brand , int> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Brand>> GetAllBrands()
        {
            var brands= await _repository.GetAllAsync();
            if (brands is not null)
            {
                return brands;
            }
            else
            {
                throw new Exception("Not Fownd Brands");
            }
          
        }

    }
}
