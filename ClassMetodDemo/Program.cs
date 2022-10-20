using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.name = "Alparslan";
            musteri1.lastName = "Aydoğan";
            musteri1.adress ="KYK";
            musteri1.ID =789;

            Musteri musteri2 = new Musteri();
            musteri2.name = "Kasım";
            musteri2.lastName = "Tatli";
            musteri2.adress = "Ev";
            musteri2.ID = 154;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteriler);
            
            





        }
    }
}
