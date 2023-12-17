using BLL.Services.Constracts;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementations
{
	public class OrtherService : IOrtherService
	{
		private readonly InformationRepository _repositoryEmployee;
		private readonly UserRepository _repositoryUser;

		public OrtherService(
			InformationRepository repositoryEmployee,
			UserRepository repositoryUser)
		{
			_repositoryEmployee = repositoryEmployee;
			_repositoryUser = repositoryUser;
		}

		public async Task<bool> CheckEmail(string email)
		{
			var Employee = _repositoryEmployee.GetEmployeeByEmail(email);
			if (Employee == null)
			{
				return false;
			}
			return true;
		}

		public async Task<bool> CheckPhoneNumber(string phoneNumber)
		{
			var Employee = _repositoryEmployee.GetEmployeeByPhoneNumber(phoneNumber);
			if (Employee == null)
			{
				return false;
			}
			return true;
		}

		public async Task<bool> CheckUsername(string username)
		{
			var Employee = _repositoryUser.GetUserByUsername(username);
			if (Employee == null)
			{
				return false;
			}
			return true;
		}
	}
}