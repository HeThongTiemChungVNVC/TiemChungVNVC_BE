namespace DAL.Dtos
{
    public class DtoVaccine : BaseEntity
    {
        public string? Prevention { get; set; }
        public string? NameVaccine { get; set; }
        public string InjectionSite { get; set; }
        public string? Image { get; set; }
        public string Condition { get; set; }
        public string CategoryVaccineId { get; set; }
        public DtoInjectionChart InjectionChart { get; set; }

        //
        public ICollection<DtoVaccineBatch> VaccineBatches { get; set; }

        public DtoCategoryVaccine CategoryVaccine { get; set; }

        public DtoVaccine()
        {
            VaccineBatches = new HashSet<DtoVaccineBatch>();
        }
    }
}