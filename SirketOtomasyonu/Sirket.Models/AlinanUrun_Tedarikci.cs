using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("AlinanUrun_Tedarikci")]
    public class AlinanUrun_Tedarikci
    {
        [Key]
        [Column(Order =10)]
        public int AlınanUrunID { get; set; }
        [Key]
        [Column(Order = 20)]
        public int TedarikID { get; set; }
        


        [ForeignKey("AlınanUrunID")]
        public virtual AlınanUrun AlınanUrunu { get; set; }
        [ForeignKey("TedarikID")]
        public virtual Tedarikci Tedarikcisi { get; set; }
    }
}
