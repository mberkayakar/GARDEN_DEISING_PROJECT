using DataAccessLayer_;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using System.Linq.Expressions;
using DataAccessLayer_.Abstract;
using System.Data.Entity;

namespace BusinessLayer
{
    public class GenericManager<T> : IGenericServices<T>
    {
        private readonly IRepository<T> _repository;

        public GenericManager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public int Additem(T t)
        {
            // int atar isen ekledigin değer sayısını gorursun dogru olan o
           var addedEntity = _repository.Insert(t);
            return addedEntity;
        }

        public int DeleteById(int P)
        {
            var deletedEntity = _repository.Delete(GetById(P));
            return deletedEntity;
        }

        public List<T> Getall()
        {
            return _repository.GetAll();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty)
        {
            var query = _repository.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperty.Any()) // içi dolu mu diye kontrol ediyorum
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item); // gelen değerleri ekliyorum
                }
            }

            return query.ToList();
        }

        public T GetByFilter(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty)
        {
            var query = _repository.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperty.Any()) // içi dolu mu diye kontrol ediyorum
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item); // gelen değerleri ekliyorum
                }
            }

            return query.FirstOrDefault();
        }

        public T GetById(int id)
        {
            return _repository.GetTByID(id);
        }

        public void TDelete(T t)
        {
            _repository.Delete(t); // bu tehlikeli yöntem haberin olsun
        }

        public int Update(T t)
        {
            var updatedEntity = _repository.Update(t);
            return updatedEntity;
        }
    }
}
