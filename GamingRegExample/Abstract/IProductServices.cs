using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Entites;
namespace GamingRegExample.Abstract
{
    public interface IProductServices
    {
        public void Add(IEntities product);
        public void Delete(IEntities product);
        public void Update(IEntities product);
    }
}
