using DTOs.Cars;

namespace DTOs.Brand
{
    public class BrandLargeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarDTO> CarsDTO { get; set; }
    }
}
