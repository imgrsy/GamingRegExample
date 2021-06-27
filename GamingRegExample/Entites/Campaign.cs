using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Abstract;

namespace GamingRegExample.Entites
{
    public class Campaign:IEntities
    {
        public int Id { get; set; }
        public string CampaingName { get; set; }
        public double Discount { get; set; }
    }
}
