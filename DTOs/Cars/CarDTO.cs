namespace DTOs.Cars
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string? ModelName { get; set; }
        public string? ModelType { get; set; }

        public DateTime? ModelYear { get; set; }
        public string? Power { get; set; }
    }
}
