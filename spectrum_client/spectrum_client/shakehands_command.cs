using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spectrum_client
{
    class shakehands_message
    {
        private byte[] message;

        public shakehands_message()
        {
            message = new byte[] { 0x3A,0xA3,0x05,0x00,0x00,0xA2,0x10,0xC3};            
        }

        public shakehands_message(byte[] byte_list)
        {
            message = byte_list;
        }

        public byte[] Message
        {
            get { return message;}
            set { message = value; }
        }
    }
}
