// ***********************************************************************
// 文件名(File Name):            M_Multi_Cast.cs
//
// 数据表(Tabels):               Nothing
//
// 作者(Author):                 谭河益
//
//日期(Create Date):             2019.07.03
//
// 修改记录(Revision History): 
//     R1:                       
//     修改作者：                 
//     修改日期：                 
//     修改理由：                 
//
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DP3300
{
    class M_Multi_Cast
    {
        private UdpClient client;
        private IPAddress multiAddress;
        private int multiPort;
        private IPEndPoint multicastEnd;
        private IPEndPoint tcpServer;
        private byte[] command;

        public M_Multi_Cast()
        {
            multiAddress = IPAddress.Parse("238.228.218.208");
            multiPort = 12321;
            multicastEnd = new IPEndPoint(IPAddress.Parse("238.228.218.208"), 12321);
            client = new UdpClient(12321);
            client.JoinMulticastGroup(IPAddress.Parse("238.228.218.208"));

            tcpServer = new IPEndPoint(IPAddress.Parse("10.10.100.100"), 6000);
            command = new byte[]{0x3A, 0xA3, 0x28, 0x00, 0x00, 0xA4, 0x50, 0x01, 0x70, 0x17,
                                0x0A, 0x0A, 0x64, 0x64, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0xC3};
        }

        public M_Multi_Cast(string multi_addr, int multi_port, string server_addr, int server_port)
        {
            multiAddress = IPAddress.Parse(multi_addr);
            multiPort = multi_port;
            client = new UdpClient(multi_port);
            multicastEnd = new IPEndPoint(IPAddress.Parse(multi_addr), multi_port);
            client.JoinMulticastGroup(IPAddress.Parse(multi_addr));

            // 设置服务端IP地址
            byte[] addr_bytes = new byte[4];
            string[] addr_strs = server_addr.Split('.');
            addr_bytes[0] = Byte.Parse(addr_strs[0]);
            addr_bytes[1] = Byte.Parse(addr_strs[1]);
            addr_bytes[2] = Byte.Parse(addr_strs[2]);
            addr_bytes[3] = Byte.Parse(addr_strs[3]);
            //设置服务端PORT
            byte[] port_buff = BitConverter.GetBytes(server_port);

            command = new byte[]{0x3A, 0xA3, 0x28, 0x00, 0x00, 0xA4, 0x50, 0x01, port_buff[0], port_buff[1],
                                addr_bytes[0], addr_bytes[1], addr_bytes[2], addr_bytes[3], 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0xC3 };
        }

        public void send_command()
        {
            client.Send(command,command.Length,multicastEnd);
        }
    }
}
