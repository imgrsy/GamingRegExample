using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Abstract;
namespace GamingRegExample.Abstract
{
    public interface ICartServices
    {
        public void Buy(params IEntities[] cart);

    }
}
