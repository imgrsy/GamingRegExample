using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Entites;

namespace GamingRegExample.Abstract
{
    public interface ICustomerService
    {
        public void Add(IEntities customer);
        public void Update(IEntities customer);
        public void Delete(IEntities customer);
    }
}
