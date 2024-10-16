using RateApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Infrastructure.Generic
{
    // WE DONT USE IT 
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly GenericDao<T> _dao;
        public Repository(GenericDao<T> dao)
        {
            _dao = dao;
        }
        public void Create(T entity)
        {
            _dao.Create(entity);
        }
        public T GetById(int id)
        {
            return _dao.GetById(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _dao.GetAll();
        }
        public void Update(T entity)
        {
            _dao.Update(entity);
        }
        public void Delete(int id)
        {
            _dao.Delete(id);
        }
    }
}
