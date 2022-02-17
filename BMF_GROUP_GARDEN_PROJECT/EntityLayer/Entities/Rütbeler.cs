using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Rütbeler
    {
        [Key]
        public int ID { get; set; }
        public string Rütbler { get; set; }
    }
}
