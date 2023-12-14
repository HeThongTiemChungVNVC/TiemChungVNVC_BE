using DAL.Dtos;

namespace Repository.Repository
{
	public interface IRepository<T> where T : BaseEntity
	{
		T Get(string Id);

		IEnumerable<T> GetAll();

		T Insert(T entity);

		void Update(T entity);

		void Delete(T Id);

		void SaveChanges();
	}
}