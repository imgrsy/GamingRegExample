using GamingRegExample.Abstract;
using GamingRegExample.Entites;
namespace GamingRegExample.Concrete
{
    class CustomerCheckManager : ICustomerCheckServices
    {
        public bool RealPerson(IEntities person)
        {
            if (((Customer)person).BirthYear == "1500")
            {

                return true;

            }
            else
            {

                return false;
            }
        }
    }
}
