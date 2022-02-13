using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(100)]
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Password_Reset_Code { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
 











    }
}
