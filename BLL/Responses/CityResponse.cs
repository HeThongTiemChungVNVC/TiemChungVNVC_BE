using DAL.Dtos;

namespace BLL.Responses
{
	public class CityResponse : BaseEntity
	{
		public string NameCity { get; set; }

		public List<DistrictResponse> Districts { get; set; }
	}
}