using GamingRegExample.Abstract;
using GamingRegExample.Concrete;
using GamingRegExample.Entites;
using System;

namespace GamingRegExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // müşteri yarat
            IEntities musteri = new Customer()
            {
                Id = 1,
                FirstName = "DemoUser",
                LastName = "DemoUserLastname",
                BirthYear = "1501",
                NationalityId = "11111111111"
            };
            //müşteri yönet
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(musteri);
            customerManager.Delete(musteri);
            customerManager.Update(musteri);
            Console.WriteLine("*****E*****");
            //ürün yarat
            IEntities urun = new Product()
            {
                Id = 1,
                ProductName = "Jilet",
                UnitPrice = 10.90
            };
            //ürün yönet
            ProductManager productManager = new ProductManager();
            productManager.Add(urun);
            productManager.Update(urun);
            Console.WriteLine("*****E******");
            //kampanya yarat
            IEntities kampanya = new Campaign()
            { Id = 1, CampaingName = "kapatıyoruz", Discount = 5 };
            //kampanya yönet
            CampaignManager campaign = new CampaignManager();
            campaign.Add(kampanya);
            campaign.Delete(kampanya);
            campaign.Update(kampanya);
            Console.WriteLine("*****E******");
            //Satın alma,müşteri ilişkilendirme, kampanya ilişkilendirme
            CartManager cartManager = new CartManager();
            cartManager.Buy(musteri, urun, kampanya);


            Console.ReadKey();
        }
    }
}
