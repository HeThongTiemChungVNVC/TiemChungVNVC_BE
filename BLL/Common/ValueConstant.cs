using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common
{
	public static class ValueConstant
	{
		public const int PENDING = 0; // đang chờ khám sàng lọc
		public const int SCREENED = 1; // đã khám sàng lọc
		public const int NO_INJECTIONS_ALLOWED = 2; // không được phép tiêm
		public const int AWAITING_PAYMENT = 3; // đang chờ thanh toán
		public const int PAID = 4; // đã thanh toán
		public const int MONITORING_AFTER_VACCINATION = 5; // quan sát sau tiêm
		public const int NO_ADVERSE_EFFECTS = 6; // không xảy ra phản ứng gì
		public const int EXPERIENCING_SIDE_EFFECTS = 7; // có xảy ra phản ứng
	}
}