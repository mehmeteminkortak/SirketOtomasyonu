using Sirket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siket.DAL
{
    public class MyContext:DbContext
    {
        public MyContext()
            : base("name=MyCon")
        {
        }
        public virtual DbSet<AlınanKategori> AlınanKategoriler { get; set; }
        public virtual DbSet<AlinanUrun_Tedarikci> AlinanUrun_Tedarikciler { get; set; }
        public virtual DbSet<AlınanUrun> AlınanUrunler { get; set; }
        public virtual DbSet<Departman> Departmanlar { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<Tedarikci> Tedarikciler { get; set; }
        public virtual DbSet<UretilenUrun> UretilenUrunler { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        public virtual DbSet<OdemeDetay> OdemeDetaylar { get; set; }

    }
}
