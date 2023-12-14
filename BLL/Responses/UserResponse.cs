using DAL.Dtos;

namespace BLL.Responses
{
    public class UserResponse : BaseEntity
    {
        public string Username { get; set; }
        public string AccessToken { get; set; }
        public string RefeshToken { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string UserId { get; set; }
        public string Role { get; set; }
        public DateTime Dob { get; set; }
    }
}