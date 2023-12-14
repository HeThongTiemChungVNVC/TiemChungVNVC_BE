namespace DAL.Dtos
{
    public class DtoDetailMedicalRecord : BaseEntity
    {
        public int BodyTemperature { get; set; }
        public string BackgroundIllness { get; set; } // benh nen
        public string IdMedicalRecord { get; set; }
        public DtoMedicalRecord MedicalRecord { get; set; }
    }
}