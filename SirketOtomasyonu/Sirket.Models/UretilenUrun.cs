using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("UretilenUrunler")]
    public class UretilenUrun
    {
        [Key]
        public int UretilenUrunID { get; set; }
        [Required]
        public int KategoriID { get; set; }
        [Required]
        [StringLength(100)]
        public string UeretilenUrunAdi { get; set; }
        public int Stok { get; set; } = 0;
        public decimal Fiyat { get; set; } = 0;

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }
        
        public override string ToString() => $"{this.UeretilenUrunAdi}";
        public virtual List<Siparis> Siparisler { get; set; } = new List<Siparis>();
    }
}
