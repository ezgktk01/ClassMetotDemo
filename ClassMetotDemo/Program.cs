using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ezgi";
            musteri1.Soyadi = "Kütük";
            musteri1.Yas = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Cengiz";
            musteri2.Yas = 26;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Derin";
            musteri3.Soyadi = "Kütük";
            musteri3.Yas = 22;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteriler);
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            Console.ReadLine();

        }
    }
}
