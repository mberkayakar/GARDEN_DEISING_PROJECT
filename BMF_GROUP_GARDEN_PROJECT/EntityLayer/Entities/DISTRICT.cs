using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Entities
{
    public class DISTRICT
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public CITY CITY { get; set; }


    }
}
