using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("SiparisDetaylari")]
    public class SiparisDetay
    {
        [Key]
        public int SiparisDetayID { get; set; }
        [Required]
        public int MusteriID { get; set; }
        [Required]
        public int SiparisID { get; set; }
        public DateTime SonOdemeTarihi { get; set; }

        
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
        public virtual List<OdemeDetay> OdemeDetaylari { get; set; } = new List<OdemeDetay>();

        public override string ToString() => $"{this.Siparis.UretilenUrun.UeretilenUrunAdi}";
    }
}
