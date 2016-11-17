using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.Models
{
    [Table("Departmanlar")]
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmanAdi { get; set; }

        public virtual List<Personel> Personeller { get; set; } = new List<Personel>();
        public override string ToString() => $"{this.DepartmanAdi}";
    }
}
