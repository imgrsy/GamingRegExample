using GamingRegExample.Abstract;
using GamingRegExample.Entites;
using System;

namespace GamingRegExample.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerCheckServices _customerCheckServices;
        public CustomerManager(ICustomerCheckServices customerCheckServices)
        {
            _customerCheckServices = customerCheckServices;
        }

        public void Add(IEntities customer)
        {
            if (_customerCheckServices.RealPerson(customer)==true)
            {
                Console.WriteLine("Sisteme Kayıt Yapıldı : " + ((Customer)customer).FirstName);
            }else
            {
                Console.WriteLine("Sistem kaydı başarısız, doğum yılı kontrolünden geçemediniz");
            }
           
        }


        public void Delete(IEntities customer)
        {
            Console.WriteLine("Kaydınız Başarıyla Silinmiştir " + ((Customer)customer).FirstName);
        }

        public void Update(IEntities customer)
        {
            Console.WriteLine("Sistem Bilgileriniz Güncellenmiştir " + ((Customer)customer).FirstName);
        }
    }
}
