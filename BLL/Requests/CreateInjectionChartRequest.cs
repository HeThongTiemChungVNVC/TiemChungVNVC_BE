namespace BLL.Requests
{
    public class CreateInjectionChartRequest
    {
        public int Doses { get; set; } // Số mũi
        public int Interval { get; set; } // Khoảng cách ngày
        public bool Reminder { get; set; } // Nhắc lại hay không nhắc lại
        public string IdVaccine { get; set; }
    }
}