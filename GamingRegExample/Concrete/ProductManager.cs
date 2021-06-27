using GamingRegExample.Abstract;
using GamingRegExample.Entites;
using System;

namespace GamingRegExample.Concrete
{
    public class ProductManager : IProductServices
    {
        
        public void Add(IEntities product)
        {
           
            Console.WriteLine("Ürün eklendi: " + ((Product)product).Id + "--" + ((Product)product).ProductName + "--  Price:  " + ((Product)product).UnitPrice);
        }

        public void Delete(IEntities product)
        {
            Console.WriteLine("Ürün silindi: " + ((Product)product).Id + "--" + ((Product)product).ProductName + "--  Price:  " + ((Product)product).UnitPrice);

        }

        public void Update(IEntities product)
        {
            Console.WriteLine("Ürün güncellendi: " + ((Product)product).Id + "--" + ((Product)product).ProductName + "--  Price:  " + ((Product)product).UnitPrice);
        }
        
        
    }
}
