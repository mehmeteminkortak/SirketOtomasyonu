using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("AlınanUrunler")]
    public class AlınanUrun
    {
        [Key]
        public int AlınanUrunID { get; set; }

        public int AlınanKategoriID { get; set; }
        [StringLength(75)]
        [Required]
        public string AlınanUrunAdı { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }

        [ForeignKey("AlınanKategoriID")]
        public virtual AlınanKategori AlınanKategori { get; set; }
        
        public virtual List<AlinanUrun_Tedarikci> AlinanUrun_Tedarikci { get; set; } = new List<AlinanUrun_Tedarikci>();
        public override string ToString() => $"{this.AlınanUrunAdı}";
    }
}
