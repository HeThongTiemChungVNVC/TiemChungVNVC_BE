using DAL.Dtos;
using Repository.Repository;
using Repository.DbContexts;

namespace Repository.Repositories
{
	public class UserRepository
	{
		private readonly IRepository<DtoUser> _repositoryUser;
		private readonly VNVCContext _dbContext;

		public UserRepository(
			IRepository<DtoUser> repositoryUser,
			VNVCContext dbContext)
		{
			_repositoryUser = repositoryUser;
			_dbContext = dbContext;
		}

		public List<DtoUser> GetAllUsers()
		{
			var users = from u in _dbContext.Users
						where !u.IsDeleted
						select u;
			return users.ToList();
		}

		public DtoUser GetUserByUsername(string username)
		{
			var user = (from u in _dbContext.Users
						where !u.IsDeleted && u.Username == username
						select u).FirstOrDefault();
			return user;
		}

		public DtoUser GetUserByUserId(string userId)
		{
			var user = (from u in _dbContext.Users
						where !u.IsDeleted && u.Id == userId
						select u).FirstOrDefault();
			return user;
		}

		public DtoUser GetUserByUserIdIncludeDeleted(string userId)
		{
			var user = (from u in _dbContext.Users
						where u.Id == userId
						select u).FirstOrDefault();
			return user;
		}

		public void UpdateUser(DtoUser user)
		{
			_repositoryUser.Update(user);
		}

		public DtoUser InsertUser(DtoUser user)
		{
			return _repositoryUser.Insert(user);
		}
	}
}