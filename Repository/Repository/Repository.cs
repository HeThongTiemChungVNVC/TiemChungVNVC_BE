using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Repository.DbContexts;

namespace Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly VNVCContext _context;
        private DbSet<T> entities;

        public Repository(VNVCContext context)
        {
            _context = context;
            this.entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            entities.Attach(entity);
            entities.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public T Get(string Id)
        {
            return entities.SingleOrDefault(x => x.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable().AsQueryable();
        }

        public T Insert(T entity)
        {
            entity.Id = Guid.NewGuid().ToString().Substring(0, 15).Replace('+', '_').Replace('-', '_').Replace('*', '_').Replace('/', '_');
            entities.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}