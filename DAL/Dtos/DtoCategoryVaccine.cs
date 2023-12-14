namespace DAL.Dtos
{
    public class DtoCategoryVaccine : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<DtoVaccine> Vaccines { get; set; }

        public DtoCategoryVaccine()
        {
            Vaccines = new HashSet<DtoVaccine>();
        }
    }
}