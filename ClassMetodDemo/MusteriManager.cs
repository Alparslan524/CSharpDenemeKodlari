using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    public class MusteriManager
    {
       
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.name+" isimli müşteriyi eklediniz.");            
        }

        public void MusteriListele(Musteri[] musteri)
        {
            foreach (var musteri1 in musteri)
            {
                Console.WriteLine("Isim: "+musteri1.name+"\n"+"Soyisim: "+musteri1.lastName+"\n" +
                    "Adres: "+musteri1.adress+"\n"+"Müşteri ID: "+musteri1.ID);
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.name + " isimli müşteri silindi!!!");
        }
    }
}
