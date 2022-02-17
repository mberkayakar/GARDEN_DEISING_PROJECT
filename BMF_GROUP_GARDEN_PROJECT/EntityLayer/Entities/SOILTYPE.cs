using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class SOILTYPE
    {
        [Key]
        public int AdressTypeId { get; set; }
        [Required]
        public string Types { get; set; }

    }
}
