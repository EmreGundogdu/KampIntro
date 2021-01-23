using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emre
            GercekMusteri musteri = new GercekMusteri();
            musteri.Id = 1;
            musteri.MusteriNo = "12334";
            musteri.Adi = "Emre";
            musteri.Soyadi = "Gaündoğdu";
            musteri.TcNo = "321312312";





            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri);
            musteriManager.Add(musteri2);
        }
    }
}
