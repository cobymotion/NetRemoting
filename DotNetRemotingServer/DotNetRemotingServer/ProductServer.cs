using MyProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetRemotingServer
{
    public class ProductServer : MarshalByRefObject, IProduct 
    {
        public Product find()
        {
            return new Product() { Id = "001", Name = "Product 1", Price = 100.00 };
        }

        public List<Product> findAll()
        {
            List<Product> listProducts = new List<Product>(); 
            listProducts.Add(new Product() { Id = "001", Name = "Product 1", Price = 100.00 });
            listProducts.Add(new Product() { Id = "002", Name = "Product 2", Price = 50.00 });
            listProducts.Add(new Product() { Id = "003", Name = "Product 3", Price = 100.00 });
            return listProducts; 
        }
    }
}
