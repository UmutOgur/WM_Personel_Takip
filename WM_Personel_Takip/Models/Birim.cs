using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WM_Personel_Takip.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAD { get; set; }
        public IList<Personel> parsonels { get; set; }
    }
}
