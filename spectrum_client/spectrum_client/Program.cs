using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace spectrum_client
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var client = new UdpClient();
            var ip = IPAddress.Parse("238.228.218.208");
            client.JoinMulticastGroup(ip, 10);

            var multicast = new IPEndPoint(IPAddress.Any, 0);
            byte[] bytes = client.Receive(ref multicast);
            string msg = Encoding.ASCII.GetString(bytes);
            Console.WriteLine(msg);
            */
            byte a = 0x01;
            int b = a;
            Console.WriteLine(b);

            Console.ReadKey();
        }

        static public byte[] func_byte()
        {
            string str = "string to byte test .";
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(str);
            return byteArray;
        }

        static public byte get_byte()
        {
            byte a = 0x01;
            return a;
        }
    }
}
