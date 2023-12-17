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
		private readonly IRepository<DtoEmployee> _repositoryEmployee;
		private readonly VNVCContext _dbContext;

		public InformationRepository(
			IRepository<DtoEmployee> repositoryEmployee,
			VNVCContext db)
		{
			_repositoryEmployee = repositoryEmployee;
			_dbContext = db;
		}

		public List<DtoEmployee> GetAllEmployees()
		{
			var Employees = from i in _dbContext.Employees
							where !i.IsDeleted
							select i;
			return Employees.ToList();
		}

		public DtoEmployee GetEmployeeByEmail(string email)
		{
			var Employee = (from i in _dbContext.Employees
							where !i.IsDeleted && i.Email == email
							select i).Include(x => x.User).FirstOrDefault();
			return Employee;
		}

		public DtoEmployee GetEmployeeByUserId(string userId)
		{
			var Employee = (from i in _dbContext.Employees
							where !i.IsDeleted && i.UserId == userId
							select i).Include(x => x.User).FirstOrDefault();
			return Employee;
		}

		public DtoEmployee GetEmployeeByUserIdInludeDeleted(string userId)
		{
			var Employee = (from i in _dbContext.Employees
							where i.UserId == userId
							select i).Include(x => x.User).FirstOrDefault();
			return Employee;
		}

		public DtoEmployee GetEmployeeByPhoneNumber(string phoneNumber)
		{
			var Employee = (from i in _dbContext.Employees
							where !i.IsDeleted && i.Phone == phoneNumber
							select i).Include(x => x.User).FirstOrDefault();
			return Employee;
		}

		public DtoEmployee InsertEmployee(DtoEmployee Employee)
		{
			return _repositoryEmployee.Insert(Employee);
		}

		public bool UpdateEmployee(string? userId, string? fullName, bool? gender, string? email, string? phoneNumber, string? address, DateTime? dob)
		{
			try
			{
				var Employee = (from i in _dbContext.Employees
								where i.UserId == userId
								select i).FirstOrDefault();

				if (Employee == null)
				{
					return false;
				}
				if (!string.IsNullOrEmpty(fullName))
				{
					Employee.FullName = fullName;
				}
				if (gender != null)
				{
					Employee.Gender = gender;
				}
				if (!string.IsNullOrEmpty(email))
				{
					var EmployeeDb = GetEmployeeByEmail(email);
					if (EmployeeDb != null)
					{
						if (EmployeeDb.UserId != Employee.UserId)
						{
							throw new Exception("Email already use");
						}
					}
					Employee.Email = email;
				}
				if (!string.IsNullOrEmpty(phoneNumber))
				{
					var EmployeeDb = GetEmployeeByPhoneNumber(phoneNumber);
					if (EmployeeDb != null)
					{
						if (EmployeeDb.UserId != Employee.UserId)
						{
							throw new Exception("Phone number already use");
						}
					}
					Employee.Phone = phoneNumber;
				}
				if (!string.IsNullOrEmpty(address))
				{
					Employee.Address = address;
				}
				if (dob != null)
				{
					Employee.DateOfBirth = (DateTime)dob;
				}
				Employee.UpdatedTime = DateTime.Now;
				_repositoryEmployee.Update(Employee);
				return true;
			}
			catch (Exception ec)
			{
				throw new Exception(ec.Message);
			}
		}
	}
}