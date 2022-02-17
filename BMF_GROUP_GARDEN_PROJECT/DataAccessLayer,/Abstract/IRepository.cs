using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_.Abstract
{

    // Gelen her entity nesnesini kabul etmesi için Generic Bir yapı Tanımlanmıiştır
    public interface IRepository<T>
    {
        // Execute edildikten sonra etkilenen kayıt sayısı için int tipinde bir fonksiyon tanımlaması gerçekleştirilmiştir
        int Insert(T p);
        int Update(T p);
        int Delete(T p);

        // Atılan nesneler listelenecektir.
        List<T> List();



        // Özel Koşullara Gre Filtreleme İşlemleri Gerçekleştirilecektir. 
        List<T> List(Expression<Func<T,bool>> filter);


        // verilen nesnenin id değerine gre listeleme işlemi gerçekleştirilecektir. 
        T GetTByID(int id);

        //
        T Find(Expression<Func<T, bool>> where);


        List<T> GetAll(Expression<Func<T, bool>> where = null,params Expression<Func<T, object>>[] includeProperties);
        // parametre olarak sınırsız joın alabıleceksın ama en sonda kullanmak zorundasın

        IQueryable<T> AsQueryable();

    }
}
