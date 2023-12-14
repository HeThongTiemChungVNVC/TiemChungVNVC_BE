using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Constracts
{
    public interface IOrtherService
    {
        Task<bool> CheckEmail(string email);

        Task<bool> CheckPhoneNumber(string phoneNumber);

        Task<bool> CheckUsername(string username);
    }
}