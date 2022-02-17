using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace BusinessLayer.Abstract
{
    public interface IGenericServices<T>    
    {

        int Additem(T t);
        void TDelete(T t);
        int Update(T t);
        List<T> Getall();

        List<T> GetAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);
        T GetById(int id);

        int DeleteById(int P);

        T GetByFilter(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);
    }
}
