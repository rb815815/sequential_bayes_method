// ***********************************************************************
// 文件名(File Name):            Message_Interpreter.cs
//
// 数据表(Tabels):               Nothing
//
// 作者(Author):                 谭河益
//
//日期(Create Date):             2019.07.02
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

namespace DP3300
{
    class Message_Interpreter
    {
        /// <summary>有效的祯头:两个字节，固定格式 0x3a,0xa3</summary>
        private byte[] validHead;
        /// <summary>有效的内容长度字节：三个字节，低位在前</summary>
        private byte[] validLength;
        /// <summary>有效的命令类型：不确定</summary>
        private byte validType;
        /// <summary>有效的命令码：不确定</summary>
        private byte validCode;
        /// <summary>有效的祯尾:一个字节，固定格式0xc3</summary>
        private byte validTail;
        /// <summary>有效的命令序列总字节数</summary>
        private int validTotalCount;
        /// <summary>消息是否有效标志位</summary>
        private bool msgCorrect;
        /// <summary>接收的消息</summary>
        public byte[] message;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Interpreter()
        {
            validHead = new byte[2] { 0x00, 0x00 };
            validLength = new byte[3] { 0x00, 0x00, 0x00 };
            validTail = 0x00;
            validType = 0x00;
            validCode = 0x00;
            validTotalCount = 0;
            msgCorrect = false;
        }

        /// <summary>
        /// 有效祯头属性
        /// </summary>
        public byte[] VALID_HEAD
        {
            get { return validHead; }
            set { validHead = value; }
        }

        /// <summary>
        /// 有效祯尾属性
        /// </summary>
        public byte VALID_TAIL
        {
            get { return validTail; }
            set { validTail = value; }
        }

        /// <summary>
        /// 有效内容长度字节属性
        /// </summary>
        public byte[] VALID_LENGTH
        {
            get { return validLength; }
            set { validLength = value; }
        }

        /// <summary>
        /// 有效命令类型属性
        /// </summary>
        public byte VALID_TYPE
        {
            get { return validType; }
            set { validType = value; }
        }

        /// <summary>
        /// 有效命令码属性
        /// </summary>
        public byte VALID_CODE
        {
            get { return validCode; }
            set { validCode = value; }
        }

        /// <summary>
        /// 有效命令总长度属性
        /// </summary>
        public int VALID_TOTAL_COUNT
        {
            get { return validTotalCount; }
            set { validTotalCount = value; }
        }

        /// <summary>
        /// 消息正确性标志位属性
        /// </summary>
        public bool IS_CORRECT
        {
            get { return msgCorrect; }
            set { msgCorrect = value; }
        }

        /// <summary>
        /// 检验应答消息祯头祯尾是否正常
        /// </summary>
        /// <param name="sequence">
        /// 输入的字节序列
        /// </param>
        /// <returns>
        /// 判断状态，false代表异常，true代表正常
        /// </returns>
        public bool Validate_Sequence_Head_Tail(byte[] sequence)
        {
            if (Validate_Lentgh(sequence))
            {
                // 验证消息祯头与祯尾是否符合要求
                if (validHead[0] == sequence[0] && validHead[1] == sequence[1]
                    && validTail == sequence[validTotalCount-1])
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// 验证消息字节序列长度是否正常
        /// true  代表正常
        /// false 代表异常
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public bool Validate_Lentgh(byte[] sequence)
        {
            int msgLength = sequence.Length;
            if (msgLength == validTotalCount)            
                return true;            
            else
                return false;
        }
    }

    class Message_Shakehands : Message_Interpreter
    {
        /// <summary>应答内容</summary>
        private byte ackFlag;
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Shakehands()
        {
            init();            
        }

        /// <summary>
        /// 默认构造函数,由字节序列初始化变量
        /// </summary>
        public Message_Shakehands(byte[] sequence)
        {            
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x10
        /// </summary>
        public virtual void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x10;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }

        /// <summary>
        /// 判断字节序列内容是否正确，正确则更新消息内容
        /// </summary>
        /// <param name="sequence"></param>
        public void set_message(byte[] sequence)
        {
            IS_CORRECT = Validate_Sequence_Head_Tail(sequence);
            if (IS_CORRECT)
            {
                message = sequence;
                ackFlag = message[7];
            }
        }

        /// <summary>
        /// 获取应答内容
        /// </summary>
        /// <returns></returns>
        public bool set_success()
        {
            return (IS_CORRECT && ackFlag == 0x01);
        }
    }

    class Message_Reset : Message_Shakehands
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Reset()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_Reset(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x11
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x11;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_Stop : Message_Shakehands
    {
        public Message_Stop()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_Stop(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x13
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x13;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_Config : Message_Shakehands
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Config()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_Config(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x14
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x14;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_Hardware : Message_Shakehands
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Hardware()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_Hardware(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x15
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x15;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_HighVoltage : Message_Shakehands
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_HighVoltage()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_HighVoltage(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x16
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x16;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_Auto_Spec : Message_Shakehands
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Auto_Spec()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_Auto_Spec(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x17
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x17;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_Save_Flash : Message_Shakehands
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Save_Flash()
        {
            init();
        }

        /// <summary>
        /// 构造函数，将字节序列赋予消息数据
        /// </summary>
        public Message_Save_Flash(byte[] sequence)
        {
            init();
            set_message(sequence);
        }

        /// <summary>
        /// 初始化，设置变量
        /// 设置命令码为0x17
        /// </summary>
        public override void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_LENGTH = new byte[3] { 0x06, 0x00, 0x00 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x18;
            VALID_TOTAL_COUNT = 9;
            IS_CORRECT = false;
        }
    }

    class Message_Get_Multi_Channel : Message_Interpreter
    {
        /// <summary>消息内容</summary>
        private byte[] contents;
        /// <summary>消息内容</summary>
        private byte[] icrCode;
        /// <summary>通道数</summary>
        private int channel_num;
        /// <summary>消息内容字节数映射表</summary>
        private readonly int[] channel_map = new int[7]{ 2048, 4096, 8192, 16384, 32768, 65536, 131072 };

        /// <summary>
        /// 默认构造函数，禁用
        /// </summary>
        private Message_Get_Multi_Channel(){}

        /// <summary>
        /// 构造函数，指定多道通道数
        /// </summary>
        /// <param name="channel">通道数代码，取值0~6</param>
        public Message_Get_Multi_Channel(int channel)
        {
            set_contents_length(channel);
        }

        public Message_Get_Multi_Channel(int channel, byte[] sequence)
        {
            set_contents_length(channel);
        }

        private void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA3;
            VALID_CODE = 0x12;            
        }

        public byte[] CONTENTS
        {
            get { return contents; }
            set { contents = value; }
        }

        public byte[] ICR_CODE
        {
            get { return icrCode; }
            set { icrCode = value; }
        }

        public int CHANNEL
        {
            get 
            { 
                return channel_num; 
            }
            set 
            {
                int temp = 0;
                temp = (value < 0 ? 0 : value);
                temp = (temp > 6 ? 6 : temp);
                channel_num = temp;
            }
        }

        private void set_contents_length(int channel)
        {
            CHANNEL = channel;                                          
            byte[] buff = BitConverter.GetBytes(channel_map[CHANNEL]);  // 查表获取字节数，转换为直接序列
            VALID_LENGTH[0] = buff[0];
            VALID_LENGTH[1] = buff[1];
            VALID_LENGTH[2] = buff[2];
        }

        private void set_sequence(byte[] sequence)
        {
            message = sequence;
        }
    }

    class Message_Query_SysInfo : Message_Interpreter
    {
        ///<summary>多道GUID，36字节</summary>
        private byte[] multichannelGuid;
        ///<summary>多道数量</summary>
        private byte channelCode;
        ///<summary>系统版本</summary>
        private byte[] sysVersion;
        ///<summary>通信版本</summary>
        private byte[] comVersion;
        ///<summary>多道类型</summary>
        private byte multiType;
        ///<summary>MAC地址，6字节</summary>
        private byte[] macAddress;
        ///<summary>内容字段，60字节</summary>
        private byte[] contents;

        /// <summary>
        /// 构造函数，将系统信息初始化为指定字节序列
        /// </summary>
        /// <param name="sequence"></param>
        public Message_Query_SysInfo(byte[] sequence)
        {
            init();
        }

        /// <summary>
        /// 多道GUID属性
        /// </summary>
        public byte[] MULTI_GUID
        {
            get { return multichannelGuid; }
            set { multichannelGuid = value; }
        }

        /// <summary>
        /// 通道数量属性
        /// </summary>
        public byte CHANNEL_CODE
        {
            get { return channelCode; }
            set { channelCode = value; }
        }

        /// <summary>
        /// 系统版本属性
        /// </summary>
        public byte[] SYS_VERSION
        {
            get { return sysVersion; }
            set { sysVersion = value; }
        }

        /// <summary>
        /// 通信版本属性
        /// </summary>
        public byte[] COM_VERSION
        {
            get { return comVersion; }
            set { comVersion = value; }
        }

        /// <summary>
        /// 多道类型属性
        /// 0  保留
        /// 10 代表圆筒多道
        /// 30 代表HPGE反康多道
        /// 50 代表可扩展多道
        /// </summary>
        public byte MULTI_TYPE
        {
            get { return multiType; }
            set { multiType = value; }
        }

        /// <summary>
        /// MAC地址属性
        /// </summary>
        public byte[] MAC_ADDRESS
        {
            get { return macAddress; }
            set { macAddress = value; }
        }

        /// <summary>
        /// 内容字段属性
        /// </summary>
        public byte[] CONTENTS
        {
            get { return contents; }
            set { contents = value; }
        }

        /// <summary>
        /// 初始化方法，指定消息关键信息
        /// 命令类型 0xA1
        /// 命令码   0x80
        /// </summary>
        private void init()
        {
            VALID_HEAD = new byte[2] { 0x3A, 0xA3 };
            VALID_TAIL = 0xC3;
            VALID_TYPE = 0xA1;
            VALID_CODE = 0x80;
            VALID_TOTAL_COUNT = 118;
            IS_CORRECT = false;
        }

        /// <summary>
        /// 消息赋值
        /// </summary>
        public void set_sequence(byte[] sequence)
        {
            if (Validate_Lentgh(sequence))
            {
                if (Validate_Sequence_Head_Tail(sequence))
                {
                    IS_CORRECT = true;
                    message = sequence;
                }
            }
            else
                IS_CORRECT = false;
        }
    }
}
