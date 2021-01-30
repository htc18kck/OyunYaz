using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYaz
{
    class OyuncuMenager : IOyuncuService
    {
        IKullaniciDogrula _kullaniciDogrula;

        public OyuncuMenager(IKullaniciDogrula kullaniciDogrula)
        {
            _kullaniciDogrula = kullaniciDogrula;
        }

        public void Ekle(Oyuncu oyuncu)
        {
            if (_kullaniciDogrula.Dogrula(oyuncu)==true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.kayır başarısız");
            }
        }

        public void Guncelle(Oyuncu oyuncu)
        {
            Console.WriteLine( "Kayıt guncellendi.");
        }

        public void Sil(Oyuncu oyuncu)
        {
            Console.WriteLine("kayıt silindi.");
        }
    }
}
