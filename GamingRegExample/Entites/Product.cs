using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegExample.Abstract;

namespace GamingRegExample.Entites
{
    public class Product : IEntities
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
    }
}
