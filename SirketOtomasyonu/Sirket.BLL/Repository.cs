using Sirket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket.BLL
{
    public class Repository
    {

    }
    public class AlinanKategoriRepo : RepositoryBase<AlınanKategori, int>
    {
        public List<AlınanKategori> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.AlınanKategoriAdi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class AlinanUrunRepo : RepositoryBase<AlınanUrun, int>
    {
        public List<AlınanUrun> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.AlınanUrunAdı.ToLower().Contains(kelime)).ToList();
        }
    }
    public class AlinanUrun_TedarikciRepo : RepositoryBase<AlinanUrun_Tedarikci, int>
    {
        public AlinanUrun_Tedarikci gelen { get; set; }
        public virtual void Deletee(int TedarikciID)
        {
            try
            {
                List<AlinanUrun_Tedarikci> silincekler = new AlinanUrun_TedarikciRepo().getAll().Where(x => x.TedarikID == TedarikciID).ToList();
                int indx = 0;
                foreach (var item in silincekler)
                {
                    gelen = silincekler[indx];
                    dbContext.AlinanUrun_Tedarikciler.Remove(gelen);
                    indx++;
                }
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
    public class DepartmanRepo : RepositoryBase<Departman, int>
    {
        public List<Departman> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.DepartmanAdi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class KategoriRepo : RepositoryBase<Kategori, int>
    {
        public List<Kategori> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.KategoriAdi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class MusteriRepo : RepositoryBase<Musteri, int>
    {
        public List<Musteri> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.MusteriAdi.ToLower().Contains(kelime) || x.MusteriSoyadi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class PersonelRepo : RepositoryBase<Personel, int>
    {
        public List<Personel> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.PersonelAdi.ToLower().Contains(kelime) || x.PersonelSoyadi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {

        public List<SiparisSayisi>  UruneGoreSiparisSayisi()
        {
            dbContext = new Siket.DAL.MyContext();
            var sorgu = from siparisler in dbContext.Siparisler
                        join urunler in dbContext.UretilenUrunler
                        on siparisler.UretilenUrunID equals urunler.UretilenUrunID
                        group new
                        {
                            siparisler,
                            urunler
                        } by new
                        {
                            UrunAdi = urunler.UeretilenUrunAdi,
                            urunID = siparisler.UretilenUrunID
                        } into s
                        select new SiparisSayisi
                        {
                            UrunAdi = s.Key.UrunAdi,
                            ToplamAdet = s.Sum(x => x.siparisler.Adet)
                        };
            return sorgu.ToList();
        }
        public List<Siparis> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.UretilenUrun.UeretilenUrunAdi.ToLower().Contains(kelime)).ToList();
        }
    }

    public class TedarikciRepo : RepositoryBase<Tedarikci, int>
    {
        public List<Tedarikci> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.TedarikciAdi.ToLower().Contains(kelime) || x.TedarikciSoyadi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class UretilenUrunRepo : RepositoryBase<UretilenUrun, int>
    {
        public List<UretilenUrun> Arama(string kelime)
        {
            kelime = kelime.ToLower();
            return this.getAll().Where(x => x.UeretilenUrunAdi.ToLower().Contains(kelime)).ToList();
        }
    }
    public class OdemeDetayRepo:RepositoryBase<OdemeDetay,int>
    {
        public List<OdemeDetay> Arama(DateTime seciliTarih)
        {
            return this.getAll().Where(x => x.OdemeTarihi.Day==seciliTarih.Day&& x.OdemeTarihi.Month == seciliTarih.Month && x.OdemeTarihi.Year == seciliTarih.Year).ToList();
        }
    }
    public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int>
    { }
}
