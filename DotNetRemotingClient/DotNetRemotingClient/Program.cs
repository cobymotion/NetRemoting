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

            Product product = iProduct.find();

            Console.WriteLine("{0} {1} $ {2}",product.Id, product.Name, product.Price);

            Console.ReadLine(); 

        }
    }
}
