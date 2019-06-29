using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spectrum_client
{
    class multicast_message
    {
        private byte[] message;
        public multicast_message()
        {
            message = new byte[43];
        }

        public multicast_message(byte[] byte_list)
        {
            if (byte_list.Length == 43)
                message = byte_list;
            else
                message = new byte[43];
        }

        /// <summary>
        /// Property to hold the message
        /// </summary>
        public byte[] Message
        {
            get { return message; }
            set { message = value; }
        }

        /// <summary>
        /// 获取接收消息中有效数据字节数
        /// </summary>
        /// <returns></returns>
        public int get_data_num()
        {
            byte count1 = message[2];
            byte count2 = message[3];
            byte count3 = message[4];

            return 0;
        }

        /// <summary>
        /// 获取服务端网络传输协议
        /// 1 : TCP
        /// 2 : UDP
        /// </summary>
        /// <returns></returns>
        public int get_trans_protocol()
        {
            byte flag = message[7];            
            return flag;
        }

        /// <summary>
        /// 获取服务端服务端口
        /// </summary>
        /// <returns></returns>
        public byte[] get_server_port()
        {
            byte[] server_port = new byte[2];
            server_port[0] = message[8];
            server_port[1] = message[9];

            return server_port;
        }

        /// <summary>
        /// 获取服务端ip地址
        /// </summary>
        /// <returns></returns>
        public byte[] get_server_ip()
        {
            byte[] server_ip = new byte[4];
            server_ip[0] = message[10];
            server_ip[1] = message[11];
            server_ip[2] = message[12];
            server_ip[3] = message[13];

            return server_ip;
        }
    }
}
