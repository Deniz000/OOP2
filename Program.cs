using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "123145";
            musteri1.FirstName = "Engin";
            musteri1.LastName = "Demiroğ";
            musteri1.TcNumber = "12345679788";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "15645";
            musteri2.CampanyName = "Kodlama.io";
            musteri2.TaxNumber = "4612345";

            Customer customer1 = new GercekMusteri(); //base class referans tutucu
            Customer customer2 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


             









            //Gerçek - Tüzel = Benzeme nedeniyle birbiri yerine kullanılamazlar !!!!!
            //so-l-id

        }
    }
}
