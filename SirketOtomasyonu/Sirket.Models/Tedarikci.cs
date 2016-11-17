using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    public class Tedarikci
    {
        [Key]
        public int TedarikID { get; set; }
        [Required]
        public string SirketAdi { get; set; }
        [StringLength(50)]
        [Required]
        public string  TedarikciAdi { get; set; }
        [StringLength(50)]
        [Required]
        public string TedarikciSoyadi { get; set; }
        [Required]
        public string TedarikciAdresi { get; set; }
        public string   TedarikciTelefonu { get; set; }

        // public virtual List<AlınanUrunDetay> AlınanUrunDetay { get; set; } = new List<AlınanUrunDetay>();
        public virtual List<AlinanUrun_Tedarikci> AlinanUrun_Tedarikci { get; set; } = new List<AlinanUrun_Tedarikci>();
        public override string ToString() => $"{this.SirketAdi} - {this.TedarikciAdi} {this.TedarikciSoyadi}";
    }
}
