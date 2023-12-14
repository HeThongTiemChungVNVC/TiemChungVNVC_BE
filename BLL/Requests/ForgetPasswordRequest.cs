using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Requests
{
    public class ForgetPasswordRequest
    {
        public string Email { get; set; }
        public string UrlRequest { get; set; }
    }
}