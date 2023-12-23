using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
	public class CreateDetailMedicalRequest
	{
		public int BodyTemperature { get; set; }
		public string BackgroundIllness { get; set; } // benh nen
		public string IdMedicalRecord { get; set; }

		// Additional
		public int Weight { get; set; } // cân nặng

		public int Height { get; set; } // chiều cao

		public string MedicalHistory { get; set; } // tiền sử bệnh
		public int BloodPressure { get; set; } // huyết áp
		public string CurrentHealthStatus { get; set; }  // tình trạng sức khỏe hiện tại
	}
}