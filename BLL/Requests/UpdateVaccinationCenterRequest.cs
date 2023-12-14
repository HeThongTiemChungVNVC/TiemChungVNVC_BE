namespace BLL.Requests
{
    public class UpdateVaccinationCenterRequest
    {
        public string? Id { get; set; }
        public string? CenterName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
    }
}