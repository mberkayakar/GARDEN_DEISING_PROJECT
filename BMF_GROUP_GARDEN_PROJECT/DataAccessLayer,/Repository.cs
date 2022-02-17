using DataAccessLayer_.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer_
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        Context context = new Context();
        
        DbSet<T> _object;


        public Repository()
        {
            _object = context.Set<T>();
        }

        public IQueryable<T> AsQueryable()
        {
            IQueryable<T> query = _object;
            return query;
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();

        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public List<T> GetAll(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _object;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (includeProperties.Any()) // içi dolu mu diye kontrol ediyorum
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty); // gelen değerleri ekliyorum
                }
            }

            return query.ToList();
        }

        public T GetTByID(int id)
        {

            return _object.Find(id);
        }


        public int Insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges();


        }

        public List<T> List()
        {
             
            return _object.ToList();

        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {

            return _object.Where(filter).ToList();

        }

        public int Update(T p)
        {

            return context.SaveChanges();
        }

       
    }
}
