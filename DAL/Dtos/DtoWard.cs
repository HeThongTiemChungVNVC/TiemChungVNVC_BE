namespace DAL.Dtos
{
	public class DtoWard : BaseEntity
	{
		public string NameWard { get; set; }
		public string IdDistrict { get; set; }

		public DtoDistrict District { get; set; }

		public DtoWard()
		{
		}
	}
}