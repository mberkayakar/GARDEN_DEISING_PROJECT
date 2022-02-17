using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AdressTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Types { get; set; }
    }
}
