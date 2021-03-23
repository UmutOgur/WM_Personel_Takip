using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WM_Personel_Takip.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAD { get; set; }
        public string PersnelSOYAD { get; set; }
        public string PersonelSEHİR { get; set; }

        public int BirimID { get; set; }
        public Birim Birim { get; set; }
    }
}
