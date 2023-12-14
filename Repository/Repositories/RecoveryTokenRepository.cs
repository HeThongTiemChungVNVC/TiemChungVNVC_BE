using DAL.Dtos;
using Repository.Repository;
using Repository.DbContexts;

namespace Repository.Repositories
{
	public class RecoveryTokenRepository
	{
		private readonly IRepository<DtoPasswordRecoveryToken> _repository;
		private readonly VNVCContext _db;

		public RecoveryTokenRepository(IRepository<DtoPasswordRecoveryToken> repository, VNVCContext db)
		{
			_repository = repository;
			_db = db;
		}

		public DtoPasswordRecoveryToken InsertPasswordRecoveryToken(DtoPasswordRecoveryToken passwordRecoveryToken)
		{
			return _repository.Insert(passwordRecoveryToken);
		}

		public DtoPasswordRecoveryToken CheckPincode(string pinCode, string userId)
		{
			var obj = (from c in _db.RecoveryTokens
					   where c.UserId == userId && c.PinCode == pinCode && !c.IsDeleted
					   select c).FirstOrDefault();
			return obj;
		}

		public DtoPasswordRecoveryToken CheckPincodeRegister(string pinCode, string userId)
		{
			var obj = (from c in _db.RecoveryTokens
					   where c.UserId == userId && c.PinCode == pinCode && !c.IsDeleted
					   select c).FirstOrDefault();
			return obj;
		}

		public void DeletePincode(DtoPasswordRecoveryToken passwordRecoveryToken)
		{
			passwordRecoveryToken.IsDeleted = true;
			_repository.Update(passwordRecoveryToken);
		}
	}
}