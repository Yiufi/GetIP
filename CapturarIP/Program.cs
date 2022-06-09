using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace CapturarIP
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Console.WriteLine("No Network Available");
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            var ippaddress = host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            Console.WriteLine(ippaddress);
        }
    }
}