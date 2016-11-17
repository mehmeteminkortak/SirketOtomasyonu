using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("OdemeDetaylari")]
   public class OdemeDetay
    {
        [Key]
        public int OdemeDetayID { get; set; }
        public int SiparisDetayID { get; set; }
        public int MusteriID { get; set; }
        public int SiparisID { get; set; }
        public string OdemeSekli { get; set; }
        public decimal OdedigiMiktar { get; set; }
        public DateTime OdemeTarihi { get; set; } = DateTime.Now;
        [ForeignKey("SiparisDetayID")]
        public virtual SiparisDetay SiparisDetay { get; set; }

    }
}
