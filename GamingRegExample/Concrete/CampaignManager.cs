using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Abstract;
using GamingRegExample.Entites;
namespace GamingRegExample.Concrete
{
    public class CampaignManager : ICampaignServices
    {
        public void Add(IEntities campaign)
        {
            Console.WriteLine("Kupon kodu eklendi " + " Id: " + ((Campaign)campaign).Id + " --- Kampanya adı:  " + ((Campaign)campaign).CampaingName + " --- Bedeli : " + ((Campaign)campaign).Discount);
        }

        public void Delete(IEntities campaign)
        {
            Console.WriteLine("Kupon kodu silindi " + " Id: " + ((Campaign)campaign).Id + " --- Kampanya adı:  " + ((Campaign)campaign).CampaingName + " --- Bedeli : " + ((Campaign)campaign).Discount);
        }

        public void Update(IEntities campaign)
        {
            Console.WriteLine("Kupon kodu güncellendi " + " Id: " + ((Campaign)campaign).Id + " --- Kampanya adı:  " + ((Campaign)campaign).CampaingName + " --- Bedeli : " + ((Campaign)campaign).Discount);
        }
    }
}
