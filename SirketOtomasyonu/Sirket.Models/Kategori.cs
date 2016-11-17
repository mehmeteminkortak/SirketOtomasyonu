using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Required]
        [StringLength(100)]
        public string KategoriAdi { get; set; }

        public virtual List<UretilenUrun> UretilenUrunler { get; set; } = new List<UretilenUrun>();
        public override string ToString() => $"{this.KategoriAdi}";
    }
}
