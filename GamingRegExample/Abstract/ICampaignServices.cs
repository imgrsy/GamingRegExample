using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegExample.Abstract
{
    public interface ICampaignServices
    {
        public void Add(IEntities campaign);
        public void Delete(IEntities campaign);
        public void Update(IEntities campaign);
    }
}
