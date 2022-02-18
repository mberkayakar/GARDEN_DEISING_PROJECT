using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class MessageTable
    {
        [Key]
        public int ID { get; set; }

        public int Status { get; set; }
        
        public string Başlık { get; set; }
        
        public string İçerik { get; set; }
        
        public bool okundu_bilgisi { get; set; }




    }
}
