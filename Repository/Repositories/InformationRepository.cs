using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using Repository.DbContexts;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace Repository.Repositories
{
    public class InformationRepository
    {
        private readonly IRepository<DtoInformation> _repositoryInformation;
        private readonly VNVCContext _dbContext;

        public InformationRepository(
            IRepository<DtoInformation> repositoryInformation,
            VNVCContext db)
        {
            _repositoryInformation = repositoryInformation;
            _dbContext = db;
        }

        public List<DtoInformation> GetAllInformations()
        {
            var informations = from i in _dbContext.Informations
                               where !i.IsDeleted
                               select i;
            return informations.ToList();
        }

        public DtoInformation GetInformationByEmail(string email)
        {
            var information = (from i in _dbContext.Informations
                               where !i.IsDeleted && i.Email == email
                               select i).Include(x => x.User).FirstOrDefault();
            return information;
        }

        public DtoInformation GetInformationByUserId(string userId)
        {
            var information = (from i in _dbContext.Informations
                               where !i.IsDeleted && i.UserId == userId
                               select i).Include(x => x.User).FirstOrDefault();
            return information;
        }

        public DtoInformation GetInformationByUserIdInludeDeleted(string userId)
        {
            var information = (from i in _dbContext.Informations
                               where i.UserId == userId
                               select i).Include(x => x.User).FirstOrDefault();
            return information;
        }

        public DtoInformation GetInformationByPhoneNumber(string phoneNumber)
        {
            var information = (from i in _dbContext.Informations
                               where !i.IsDeleted && i.Phone == phoneNumber
                               select i).Include(x => x.User).FirstOrDefault();
            return information;
        }

        public DtoInformation InsertInformation(DtoInformation information)
        {
            return _repositoryInformation.Insert(information);
        }

        public bool UpdateInformation(string? userId, string? fullName, string? gender, string? email, string? phoneNumber, string? address, string? dob)
        {
            try
            {
                var information = (from i in _dbContext.Informations
                                   where i.UserId == userId
                                   select i).FirstOrDefault();

                if (information == null)
                {
                    return false;
                }
                if (!string.IsNullOrEmpty(fullName))
                {
                    information.FullName = fullName;
                }
                if (!string.IsNullOrEmpty(gender))
                {
                    information.Gender = gender;
                }
                if (!string.IsNullOrEmpty(email))
                {
                    var informationDb = GetInformationByEmail(email);
                    if (informationDb != null)
                    {
                        if (informationDb.UserId != information.UserId)
                        {
                            throw new Exception("Email already use");
                        }
                    }
                    information.Email = email;
                }
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    var informationDb = GetInformationByPhoneNumber(phoneNumber);
                    if (informationDb != null)
                    {
                        if (informationDb.UserId != information.UserId)
                        {
                            throw new Exception("Phone number already use");
                        }
                    }
                    information.Phone = phoneNumber;
                }
                if (!string.IsNullOrEmpty(address))
                {
                    information.Address = address;
                }
                if (!string.IsNullOrEmpty(dob))
                {
                    DateTime result = DateTime.ParseExact(dob, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    information.Dob = result;
                }
                information.UpdatedTime = DateTime.Now;
                _repositoryInformation.Update(information);
                return true;
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }
        }
    }
}