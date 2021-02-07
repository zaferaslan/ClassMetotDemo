using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Zafer";
            musteri1.Soyad = "Aslan";
            musteri1.Id = 100;
            musteri1.Yas = 21;
            musteri1.Cinsiyet = 'E';

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Yiğitcan";
            musteri2.Soyad = "Mergen";
            musteri2.Id = 101;
            musteri2.Yas = 28;
            musteri2.Cinsiyet = 'E';

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Oktay";
            musteri3.Soyad = "Yolcu";
            musteri3.Id = 102;
            musteri3.Yas =39 ;
            musteri3.Cinsiyet = 'E';

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriListele(musteriler);

            Console.ReadLine();



        }
    }
}
