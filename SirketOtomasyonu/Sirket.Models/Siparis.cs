using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("Siparisler")]
   public class Siparis
    {
        [Key]
        public int SiparisID { get; set; }
        [Required]
        public int MusteriID { get; set; }
        [Required]
        public int UretilenUrunID { get; set; }
        [Required]
        public DateTime SiparisTarihi { get; set; }
        [Required]
        public DateTime TeslimTarihi { get; set; }
        [Required]
        public string TeslimatAdresi { get; set; }
        [Required]
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        [NotMapped]
        public decimal OdenecekTutar
        {
            get { return this.Adet * this.Fiyat; }
        }

        [ForeignKey("MusteriID")]
        public virtual Musteri Musteri { get; set; }
        [ForeignKey("UretilenUrunID")]
        public virtual UretilenUrun UretilenUrun { get; set; }
        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();
    }
}
