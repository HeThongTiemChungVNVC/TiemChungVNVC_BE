using DAL.Dtos;
using Repository.Repository;
using Repository.DbContexts;

namespace Repository.Repositories
{
	public class RefeshTokenRepository
	{
		private readonly IRepository<DtoRefeshToken> _repositoryRefeshToken;
		private readonly VNVCContext _dbContext;

		public RefeshTokenRepository(
			IRepository<DtoRefeshToken> repositoryRefeshToken,
			VNVCContext db)
		{
			_repositoryRefeshToken = repositoryRefeshToken;
			_dbContext = db;
		}

		public List<DtoRefeshToken> GetAllRefeshTokens()
		{
			var refeshTokens = from r in _dbContext.RefeshTokens
							   where !r.IsDeleted
							   select r;
			return refeshTokens.ToList();
		}

		public DtoRefeshToken GetRefeshTokenByRefeshToken(string refeshToken)
		{
			var tokenRefesh = (from r in _dbContext.RefeshTokens
							   where !r.IsDeleted && r.RefeshToken == refeshToken
							   select r).FirstOrDefault();
			return tokenRefesh;
		}

		public DtoRefeshToken GetRefeshTokenByUserId(string userId)
		{
			var tokenRefesh = (from r in _dbContext.RefeshTokens
							   where !r.IsDeleted && r.UserId == userId
							   select r).FirstOrDefault();
			return tokenRefesh;
		}

		public void RemoveRefeshToken(DtoRefeshToken refeshToken)
		{
			refeshToken.IsDeleted = true;
			_repositoryRefeshToken.Update(refeshToken);
		}

		public void InsertRefeshToken(DtoRefeshToken refeshToken)
		{
			_repositoryRefeshToken.Insert(refeshToken);
		}
	}
}