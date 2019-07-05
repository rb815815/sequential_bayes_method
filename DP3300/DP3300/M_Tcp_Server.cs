// ***********************************************************************
// 文件名(File Name):            M_Tcp_Server.cs
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
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DP3300
{
    class M_Tcp_Server
    {
        private IPAddress server_ip;
        private int server_port;
        private IPEndPoint endPoint;
        private Socket serverSocket;
        private Socket clientSocket;
        private Thread thread_connect;
        private bool isConnected;

        /// <summary>
        /// 默认构造函数，禁用
        /// </summary>
        private M_Tcp_Server() { }

        /// <summary>
        /// 构造函数，由输入参数初始化变量
        /// </summary>
        /// <param name="ip_addr">服务器IP地址</param>
        /// <param name="port">服务器端口</param>
        public M_Tcp_Server(string ip_addr, int port)
        {
            server_ip = IPAddress.Parse(ip_addr);
            server_port = port;
            endPoint = new IPEndPoint(server_ip, server_port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            isConnected = false;
        }

        /// <summary>
        /// IP地址属性
        /// </summary>
        public IPAddress IP
        {
            get { return server_ip; }
            set { server_ip = value; }
        }

        /// <summary>
        /// 端口属性
        /// </summary>
        public int PORT
        {
            get { return server_port; }
            set { server_port = value; }
        }

        /// <summary>
        /// 启动服务器
        /// </summary>
        public void start()
        {
            serverSocket.Bind(endPoint);
            serverSocket.Listen(1);
        }

        /// <summary>
        /// 非阻塞等待客户端连接       
        /// </summary>
        /// <param name="n">等待时长，单位为s</param>
        /// <returns>
        /// 连接状态标志位，false 失败，true 成功
        /// </returns>
        public bool wait_connect_in_seconds(int n)
        {
            clientSocket = serverSocket.Accept();            
            isConnected = true;
            return true;
        }

        public bool send_command(byte[] command)
        {
            if (isConnected)
            {
                clientSocket.Send(command);                
                return true;
            }
            else
            {
                return false;
            }
        }

        public byte[] get_ack()
        {
            if (isConnected)
            {
                byte[] buffer = new byte[65536];
                int count = clientSocket.Receive(buffer);
                byte[] msg = new byte[count];
                Array.Copy(buffer, 0, msg, 0, count);
                return msg;
            }
            else
            {
                return new byte[1];
            }
        }
    }
}
