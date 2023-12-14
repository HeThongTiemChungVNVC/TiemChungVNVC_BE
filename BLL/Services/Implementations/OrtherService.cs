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
		private readonly InformationRepository _repositoryInformation;
		private readonly UserRepository _repositoryUser;

		public OrtherService(
			InformationRepository repositoryInformation,
			UserRepository repositoryUser)
		{
			_repositoryInformation = repositoryInformation;
			_repositoryUser = repositoryUser;
		}

		public async Task<bool> CheckEmail(string email)
		{
			var information = _repositoryInformation.GetInformationByEmail(email);
			if (information == null)
			{
				return false;
			}
			return true;
		}

		public async Task<bool> CheckPhoneNumber(string phoneNumber)
		{
			var information = _repositoryInformation.GetInformationByPhoneNumber(phoneNumber);
			if (information == null)
			{
				return false;
			}
			return true;
		}

		public async Task<bool> CheckUsername(string username)
		{
			var information = _repositoryUser.GetUserByUsername(username);
			if (information == null)
			{
				return false;
			}
			return true;
		}
	}
}