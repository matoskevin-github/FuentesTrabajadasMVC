using MyProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChannelServices.RegisterChannel(new TcpClientChannel(), false);
                //tcp://192.168.1.10:9999"
                IProduct iproduct = (IProduct)(Activator.GetObject(typeof(IProduct), "tcp://192.168.1.10:9999/IProduct"));
                Console.WriteLine("Product Information");
                Product product = iproduct.find();
                Console.WriteLine("Id => " + product.Id);
                Console.WriteLine("Name => " + product.Name);
                Console.WriteLine("Price => " + product.Price);

                Console.WriteLine("List Product Information");
                foreach (Product item in iproduct.findAll())
                {
                    Console.WriteLine("Id => " + item.Id);
                    Console.WriteLine("Name => " + item.Name);
                    Console.WriteLine("Price => " + item.Price);
                    Console.WriteLine("=======================");
                }
               
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error => "+ ex.ToString());
            }
           

            Console.Read();
        }
    }
}
