using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class OrderDetails
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int SellerId { get; set; }
        public DateTime dateTime { get; set; }


    }
}
