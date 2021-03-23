using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WM_Personel_Takip.Models
{
    public class Admin
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int AdminID { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}
