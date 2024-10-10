using RateApp.Domain.Entities;
using RateApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Infrastructure.DAOs
{
    public class GenericDao<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericDao(ApplicationDbContext context)
        {
            _context = context;
        }     
        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity),"Cannot create a null entity");
            }

            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public T GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0",nameof(id));
            }

            return _context.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            var entities = _context.Set<T>().ToList();

            if (!entities.Any())
            {
                return new List<T>();
            }

            return entities;
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity),"Cannot update a null entity");
            }

            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0", nameof(id));
            }

            var entity = _context.Set<T>().Find(id);

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity not found");
            }

            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
