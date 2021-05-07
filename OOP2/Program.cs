using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual musteri1 = new Individual();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Tolga";
            musteri1.Soyadi = "Sözbir";
            musteri1.TcNo = "123456789";

            Corporate musteri2 = new Corporate();
            musteri2.Id = 2;
            musteri2.MusteriNo = "654321";
            musteri2.SirketAdi = "Sozbir Lojistik";
            musteri2.VergiNo = "123123123";

            Customer musteri3 = new Individual();
            Customer musteri4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri4);
        }
    }
}
