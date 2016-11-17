using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("AlınanKategori")]
    public class AlınanKategori
    {
        [Key]
        public int AlınanKategoriID { get; set; }
        [Required]
        public string AlınanKategoriAdi { get; set; }

        public virtual List<AlınanUrun> AlınanUrunler { get; set; } = new List<AlınanUrun>();

        public override string ToString() => $"{this.AlınanKategoriAdi}";
    }
}
