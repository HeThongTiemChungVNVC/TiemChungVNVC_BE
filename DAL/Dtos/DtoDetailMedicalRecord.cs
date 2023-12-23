namespace DAL.Dtos
{
	public class DtoDetailMedicalRecord : BaseEntity
	{
		public int BodyTemperature { get; set; }
		public string BackgroundIllness { get; set; } // benh nen
		public string IdMedicalRecord { get; set; }
		public DtoMedicalRecord MedicalRecord { get; set; }

		// Additional
		public int Weight { get; set; } // cân nặng

		public int Height { get; set; } // chiều cao

		public string MedicalHistory { get; set; } // tiền sử bệnh
		public int BloodPressure { get; set; } // huyết áp
		public string CurrentHealthStatus { get; set; }  // tình trạng sức khỏe hiện tại
	}
}