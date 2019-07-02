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
            UdpClient client = new UdpClient(10000);
            client.JoinMulticastGroup(IPAddress.Parse("239.255.255.250"));
            IPEndPoint multicast = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                byte[] buf = client.Receive(ref multicast);
                string msg = Encoding.Default.GetString(buf);
                Console.WriteLine(msg);
                Console.WriteLine(multicast);
            }
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
