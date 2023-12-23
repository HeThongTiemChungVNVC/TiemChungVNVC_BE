using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
	public class DetailMedicalRecordResponse : BaseEntity
	{
		public int BodyTemperature { get; set; }
		public string BackgroundIllness { get; set; } // benh nen
		public string IdMedicalRecord { get; set; }
		public MedicalRecordResponse MedicalRecord { get; set; }

		// Additional
		public int Height { get; set; } // chiều cao

		public int Weight { get; set; } // cân nặng

		public string MedicalHistory { get; set; } // tiền sử bệnh
		public int BloodPressure { get; set; } // huyết áp
		public string CurrentHealthStatus { get; set; }  // tình trạng sức khỏe hiện tại
	}
}