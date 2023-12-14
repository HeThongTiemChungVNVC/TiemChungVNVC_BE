namespace DAL.Dtos
{
	public class DtoCity : BaseEntity
	{
		public string NameCity { get; set; }

		public ICollection<DtoDistrict> Districts { get; set; }

		public DtoCity()
		{
			Districts = new HashSet<DtoDistrict>();
		}
	}
}