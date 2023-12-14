using DAL.Dtos;

namespace BLL.Responses
{
    public class PriceVaccineResponse : BaseEntity
    {
        public float CostPrice { get; set; }
        public float RetailPrice { get; set; }
        public float PreOrderPrice { get; set; }

        //
        public string IdVaccineBacth { get; set; }

        public VaccineBatchResponse VaccinceBatch { get; set; }
    }
}