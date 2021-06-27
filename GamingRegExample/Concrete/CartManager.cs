using GamingRegExample.Abstract;
using GamingRegExample.Entites;
using System;
namespace GamingRegExample.Concrete
{
    public class CartManager : ICartServices
    {
        public void Buy(params IEntities[] cart)
        {
            var fark = (((Product)cart[1]).UnitPrice) - (((Campaign)cart[2]).Discount);
            Console.WriteLine("Merhaba;\n" + ((Customer)cart[0]).LastName
                + ((Campaign)cart[2]).CampaingName + "adlı kampanyasından " +
                ((Campaign)cart[2]).Discount + " TL kazandınız");

            Console.WriteLine("Ödemeniz gereken miktar: " + fark);

        }
    }
}
