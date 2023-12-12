using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_ornek
{
    internal class Kitap
    {
        int id;
        string kitapAdi;
        string yazar;
        string sayfaSayisi;
        string tür;
        DateTime basimTarihi;
        bool cilt;

        public int Id { get => id; set => id = value; }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }
        public string Tür { get => tür; set => tür = value; }
        public DateTime BasimTarihi { get => basimTarihi; set => basimTarihi = value; }
        public bool Cilt { get => cilt; set => cilt = value; }

        public Kitap(int id, string kitapAdi, string yazar, string sayfaSayisi, string tür, DateTime basimTarihi, bool cilt)
        {
            this.id = id;
            this.kitapAdi = kitapAdi;
            this.yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
            this.tür = tür;
            this.basimTarihi = basimTarihi;
            this.cilt = cilt;
        }
    }
}
