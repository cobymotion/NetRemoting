using MyProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace DotNetRemotingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpServerChannel channel = new TcpServerChannel(5223);
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(ProductServer), "IProduct", WellKnownObjectMode.SingleCall);

                Console.WriteLine("Server is running");


                Console.ReadLine(); 
            }
            catch
            {
                Console.WriteLine("No se puede iniciar el server");
            }
        }
    }
}
