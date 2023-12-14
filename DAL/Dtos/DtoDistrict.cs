namespace DAL.Dtos
{
    public class DtoDistrict : BaseEntity
    {
        public string NameDistrict { get; set; }
        public string IdCity { get; set; }

        public DtoCity City { get; set; }
        public ICollection<DtoWard> Wards { get; set; }

        public DtoDistrict()
        {
            Wards = new HashSet<DtoWard>();
        }
    }
}