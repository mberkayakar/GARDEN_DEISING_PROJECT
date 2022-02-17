using EntityLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_
{
    public class Context:DbContext
    {
        public  DbSet<Employee> Employees { get; set; }
        public DbSet<CITY> CITIES { get; set; }
        public DbSet<DISTRICT> DISTRICTS { get; set; }
        public DbSet<Rütbeler> Rütbelers { get; set; }
        public DbSet<SOILTYPE> SOILTYPES { get; set; }
        //public DbSet<AdressTypes> AdressTypes  { get; set; }
        //public DbSet<Adress> AdressLer { get; set; }







    }
}
