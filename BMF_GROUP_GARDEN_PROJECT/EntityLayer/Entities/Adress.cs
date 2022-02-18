using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }

        public int AdressTypeİd { get; set; }

        public int DistrictId { get; set; }

        public int Clientİd { get; set; }



    }
}
