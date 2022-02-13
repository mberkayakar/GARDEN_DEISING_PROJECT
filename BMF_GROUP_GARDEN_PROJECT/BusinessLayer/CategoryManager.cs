using DataAccessLayer_;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager
    {
        Repository<Employee> personel = new Repository<Employee>();


        public List<Employee> Getall()
        {
            return personel.List();
        }

        public int Additem(Employee P)
        {

            return personel.Insert(P);
        }

        public int DeleteByİd(int P)
        {
            if (P != 0)
            {
                Employee silinecekpersonel = personel.Find(x => x.ID == P);
                return personel.Delete(silinecekpersonel);


            }
            else
            {
                return -1;
            }


        }

        public List<Employee> getbyfilter(string e)
        {
            return personel.List(x => x.UserName == e);
        }
        public int UpdatePerson(Employee employee)
        {

           

            if (employee.ID != null || employee.ID != 0)
            {

                Employee emp = personel.Find(x => x.ID == employee.ID);

                emp.Name = employee.Name;
                emp.Surname = employee.Surname;
                emp.Sex = employee.Sex;
                emp.UserName = employee.UserName;
                emp.Password = employee.Password;
                emp.Phone = employee.Phone;
                emp.Email = employee.Email;
                 

                return personel.Update(emp);


            }
            else
            {
                new ArgumentException("LÜTFEN BİR PERSONEL SEÇİMİ YAPINIZ");

            }

            return -1;
        }
    }
}
