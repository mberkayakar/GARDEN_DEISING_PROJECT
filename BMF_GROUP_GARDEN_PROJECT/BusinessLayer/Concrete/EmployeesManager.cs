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

namespace BusinessLayer
{
    public class EmployeesManager : GenericManager<Employee>, IEmployeeServices
    {
        private readonly IRepository<Employee> _repository;


        public EmployeesManager(IRepository<Employee> repository) : base(repository) // direkt aktarım yaptım
        {
            _repository = repository;
        }

        #region MyRegion



        //public List<Employee> Getall()
        //{
        //    return personel.List();
        //}



        //public int Additem(Employee P)
        //{

        //    return personel.Insert(P);
        //}

        //public int DeleteById(int P)
        //{
        //    if (P != 0)
        //    {
        //        Employee silinecekpersonel = personel.Find(x => x.ID == P);
        //        return personel.Delete(silinecekpersonel);


        //    }
        //    else
        //    {
        //        return -1;
        //    }


        //}

        //public List<Employee> getbyfilter(string e)
        //{
        //    return personel.List(x => x.UserName == e);
        //}
        //public int Update(Employee employee)
        //{

        //    if (employee.ID != null || employee.ID != 0)
        //    {

        //        Employee emp = personel.Find(x => x.ID == employee.ID);

        //        emp.Name = employee.Name;
        //        emp.Surname = employee.Surname;
        //        emp.Sex = employee.Sex;
        //        emp.UserName = employee.UserName;
        //        emp.Password = employee.Password;
        //        emp.Phone = employee.Phone;
        //        emp.Email = employee.Email;


        //        return personel.Update(emp);


        //    }
        //    else
        //    {
        //        new ArgumentException("LÜTFEN BİR PERSONEL SEÇİMİ YAPINIZ");

        //    }

        //    return -1;
        //}

        //public void TDelete(Employee t)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Employee> GetListByCount(int id, int count)
        //{
        //    throw new NotImplementedException();
        //}

        //public Employee GetById(int id, params Expression<Func<Employee, object>>[] includeProperty)
        //{
        //    throw new NotImplementedException();
        //}



        //public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null, params Expression<Func<Employee, object>>[] includeProperty)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

    }
}
