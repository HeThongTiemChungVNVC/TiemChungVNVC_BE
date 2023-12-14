﻿namespace BLL.Requests
{
    public class RegisterRequest
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Address { get; set; }
        public string UrlRequest { get; set; }
    }
}