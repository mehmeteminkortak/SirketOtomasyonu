using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("Musteriler")]
   public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        [Required]
        [StringLength(25)]
        public string MusteriAdi { get; set; }
        [Required]
        [StringLength(25)]
        public string MusteriSoyadi { get; set; }
        [Required]
        [StringLength(50)]
        public string MusteriAdres { get; set; }
        [Required]
        public string Telefon { get; set; }
        public virtual List<Siparis> Siparisler { get; set; } = new List<Siparis>();
        public override string ToString() => $"{this.MusteriAdi} {this.MusteriSoyadi}";
    }
}
