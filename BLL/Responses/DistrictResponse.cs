using DAL.Dtos;

namespace BLL.Responses
{
    public class DistrictResponse : BaseEntity
    {
        public string NameDistrict { get; set; }
        public List<WardResponse> Wards { get; set; }
    }
}