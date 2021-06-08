using MyProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace DotNetRemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpClientChannel(), false);
            IProduct iProduct = (IProduct)(Activator.GetObject(typeof(IProduct),
                "tcp://localhost:5223/IProduct"));

            iProduct.add(new Product() { Id="007", Name="Este es el siete", Price = 1000 });

            List<Product> productos = iProduct.findAll(); 
            foreach(Product product in productos)

               Console.WriteLine("{0} {1} $ {2}",product.Id, product.Name, product.Price);

            Console.ReadLine(); 

        }
    }
}
