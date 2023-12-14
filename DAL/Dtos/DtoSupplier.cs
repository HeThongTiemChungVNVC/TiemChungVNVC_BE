namespace DAL.Dtos
{
    public class DtoSupplier : BaseEntity
    {
        public string NameSupplier { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<DtoVaccineBatch> VaccineBatches { get; set; }

        public DtoSupplier()
        {
            VaccineBatches = new HashSet<DtoVaccineBatch>();
        }
    }
}