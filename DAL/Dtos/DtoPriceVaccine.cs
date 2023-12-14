namespace DAL.Dtos
{
    public class DtoPriceVaccine : BaseEntity
    {
        public float CostPrice { get; set; }
        public float RetailPrice { get; set; }
        public float PreOrderPrice { get; set; }

        //

        public string IdVaccineBacth { get; set; }

        public DtoVaccineBatch VaccinceBatch { get; set; }
    }
}