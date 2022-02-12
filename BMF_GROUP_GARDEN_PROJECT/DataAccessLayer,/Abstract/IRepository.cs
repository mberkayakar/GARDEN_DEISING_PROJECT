using System;
using System.Collections.Generic;
using System.Linq;
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

        // verilen nesnenin id değerine gre listeleme işlemi gerçekleştirilecektir. 
        T GetTByID(int id);




    }
}
