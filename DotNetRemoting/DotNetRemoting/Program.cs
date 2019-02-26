using MyProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace DotNetRemoting
{
   public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // ChannelServices.RegisterChannel(new TcpClientChannel(), false);
                //IProduct product = (IProduct)(Activator.GetObject(typeof(IProduct), "tcp://localhost:9999/IProduct"));
                TcpChannel channel = new TcpChannel(9999);
                ChannelServices.RegisterChannel(channel, false);
            
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ProductServer), "IProduct", WellKnownObjectMode.SingleCall);
                Console.WriteLine("Server's runnig.....");
            }
            catch (Exception)
            {
                Console.WriteLine("Can't start server");
            }
         Console.Read();
        }
    }
}
