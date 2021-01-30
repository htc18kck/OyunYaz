using System;

namespace OyunYaz
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuMenager oyuncuMenager = new OyuncuMenager(new YeniDogrulama());
            //OyuncuMenager oyuncuMenager = new OyuncuMenager(new OyuncuDogrula());
            oyuncuMenager.Ekle(new Oyuncu { Id = 1,BirthYear=1985,FistName="engin" ,LastName="demiroğ",IdentityNumber= 198756462 }) ;
            KampanyaMenager kampanyaMenager = new KampanyaMenager();
            kampanyaMenager.KampanyaId = 1;
            kampanyaMenager.KampanyaAdi = "indirimli";
            kampanyaMenager.KampanyaEkle();
            
       



        }
    }
}
