using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYaz
{
    interface IOyuncuService
    {
        void Ekle(Oyuncu oyuncu);
        void Guncelle(Oyuncu oyuncu);
        void Sil(Oyuncu oyuncu);
    }
}
