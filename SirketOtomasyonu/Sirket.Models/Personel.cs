using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("Personeller")]
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public int DepartmanID { get; set; }
        [Required]
        [StringLength(40)]
        public string PersonelAdi { get; set; }
        [Required]
        [StringLength(40)]
        public string PersonelSoyadi { get; set; }
        public DateTime BaslangicTarihi { get; set; } = DateTime.Now;
        public DateTime? CıkısTarihi { get; set; }
        [Required]
        [StringLength(30)]
        public string Telefon { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public decimal GunlukMaas { get; set; }
        [Required]
        public int CalistigiGunSayisi { get; set; } = 1;


        [NotMapped]
        public decimal ToplamMaas
        {
            get
            {
                return GunlukMaas * CalistigiGunSayisi;
            }
        }


        [ForeignKey("DepartmanID")]
        public virtual Departman Departman { get; set; }
        public override string ToString() => $"{this.PersonelAdi} {this.PersonelSoyadi}";

    }
}
