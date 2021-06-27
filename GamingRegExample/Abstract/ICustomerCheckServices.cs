using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Abstract;

namespace GamingRegExample.Abstract
{
    public interface ICustomerCheckServices
    {
        public bool RealPerson(IEntities person);
    }
}
