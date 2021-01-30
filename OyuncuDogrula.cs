using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYaz
{
    class OyuncuDogrula : IKullaniciDogrula
    {
        public bool Dogrula(Oyuncu oyuncu)
        {
            if (oyuncu.BirthYear == 1985 && oyuncu.FistName == "engin" && oyuncu.LastName == "demiroğ" && oyuncu.IdentityNumber == 198756461)


            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
