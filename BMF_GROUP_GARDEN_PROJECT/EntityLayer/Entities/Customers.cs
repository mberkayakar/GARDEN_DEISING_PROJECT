using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public string SEX { get; set; }



    }
}
