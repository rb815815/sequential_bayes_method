// ***********************************************************************
// 文件名(File Name):            command_composer.cs
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

namespace RN_recognition
{
    class Command_Composer
    {
        /// <summary>祯头:两个字节，固定格式 0x3a,0xa3</summary>
        private byte[] head = new byte[]{0x3a, 0xa3};
        /// <summary>命令长度标识字节</summary>
        private byte[] commandLength = new byte[3] { 0x00, 0x00, 0x00 };
        /// <summary>命令类型：不确定</summary>
        private byte commandType = 0x00;
        /// <summary>命令码：不确定</summary>
        private byte commandCode = 0x00;
        /// <summary>祯尾:一个字节，固定格式0xc3</summary>
        private byte tail = 0xc3;
        /// <summary>命令总长度</summary>
        private int totalLength = 8;
        /// <summary>命令内容长度</summary>
        private int dataLength = 5;

        /// <summary>
        /// 祯头属性
        /// </summary>
        public byte[] HEAD
        {
            get { return head; }
            set { head = value; }
        }

        /// <summary>
        /// 内容长度字节序列属性
        /// </summary>
        public byte[] COMMAND_LENGTH
        {
            get { return commandLength; }
            set { commandLength = value; }
        }

        /// <summary>
        /// 命令类型属性
        /// </summary>
        public byte TYPE
        {
            get { return commandType; }
            set { commandType = value; }
        }

        /// <summary>
        /// 命令码属性
        /// </summary>
        public byte CODE
        {
            get { return commandCode; }
            set { commandCode = value; }
        }

        /// <summary>
        /// 祯尾属性
        /// </summary>
        public byte TAIL
        {
            get { return tail; }
            set { tail = value; }
        }

        /// <summary>
        /// 命令总长度属性
        /// </summary>
        public int TOTAL_LENGTH
        {
            get { return totalLength; }
            set { totalLength = value; }
        }

        /// <summary>
        /// 命令内容长度属性
        /// </summary>
        public int DATA_LENGTH
        {
            get { return dataLength; }
            set { dataLength = value; }
        }

        /// <summary>
        /// 根据命令内容计算数据长度
        /// </summary>
        /// <param name="data">命令字节序列</param>
        public void set_content_length(int length)
        {
            byte[] dataBuff = BitConverter.GetBytes(length);
            byte[] tmp = new byte[3] { dataBuff[0], dataBuff[1], dataBuff[3] };
            COMMAND_LENGTH = tmp;
        }

        /// <summary>
        /// 获取完整的命令字节序列
        /// </summary>
        /// <returns></returns>
        public virtual byte[] get_command()
        {
            return head;
        }
    }

    class Command_Shakehands : Command_Composer
    {
        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Command_Shakehands()
        {
            DATA_LENGTH = 5;
            TYPE = 0xA2;
            CODE = 0x10;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 获取侦测（握手）命令
        /// </summary>
        /// <returns>握手命令字节序列</returns>
        public override byte[] get_command()
        {
            byte[] command = new byte[TOTAL_LENGTH];
            // 填充命令字节序列
            command[0] = HEAD[0];
            command[1] = HEAD[1];
            command[2] = COMMAND_LENGTH[0];
            command[3] = COMMAND_LENGTH[1];
            command[4] = COMMAND_LENGTH[2];
            command[5] = TYPE;
            command[6] = CODE;
            command[7] = TAIL;
            return command;
        }
    }

    class Command_Reset : Command_Composer
    {
        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Command_Reset()
        {
            DATA_LENGTH = 5;
            TYPE = 0xA2;
            CODE = 0x11;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 获取复位并重启测量命令
        /// </summary>
        /// <returns>复位令字节序列</returns>
        public override byte[] get_command()
        {
            byte[] command = new byte[TOTAL_LENGTH];
            // 填充命令字节序列
            command[0] = HEAD[0];
            command[1] = HEAD[1];
            command[2] = COMMAND_LENGTH[0];
            command[3] = COMMAND_LENGTH[1];
            command[4] = COMMAND_LENGTH[2];
            command[5] = TYPE;
            command[6] = CODE;
            command[7] = TAIL;
            return command;
        }
    }

    class Command_Get_Multi_Channel : Command_Composer
    {
        /// <summary>命令内容</summary>
        private byte command_content = 0x00;

        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Command_Get_Multi_Channel()
        {
            DATA_LENGTH = 6;
            TOTAL_LENGTH = 9;
            TYPE = 0xA2;
            CODE = 0x11;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Command_Get_Multi_Channel(int num)
        {
            DATA_LENGTH = 6;
            TOTAL_LENGTH = 9;
            TYPE = 0xA2;
            CODE = 0x12;
            set_content_length(DATA_LENGTH);
            byte[] buff = BitConverter.GetBytes(num);
            CONTENT = buff[0];            
        }

        public byte CONTENT
        {
            get { return command_content; }
            set { command_content = value; }
        }

        /// <summary>
        /// 获取复位并重启测量命令
        /// </summary>
        /// <returns>复位令字节序列</returns>
        public override byte[] get_command()
        {
            byte[] command = new byte[TOTAL_LENGTH];
            // 填充命令字节序列
            command[0] = HEAD[0];
            command[1] = HEAD[1];
            command[2] = COMMAND_LENGTH[0];
            command[3] = COMMAND_LENGTH[1];
            command[4] = COMMAND_LENGTH[2];
            command[5] = TYPE;
            command[6] = CODE;
            command[7] = CONTENT;
            command[8] = TAIL;
            return command;
        }
    }

    class Comman_Stop : Command_Composer
    { 
        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Comman_Stop()
        {
            DATA_LENGTH = 5;
            TYPE = 0xA2;
            CODE = 0x13;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 获取复位并重启测量命令
        /// </summary>
        /// <returns>复位令字节序列</returns>
        public override byte[] get_command()
        {
            byte[] command = new byte[TOTAL_LENGTH];
            // 填充命令字节序列
            command[0] = HEAD[0];
            command[1] = HEAD[1];
            command[2] = COMMAND_LENGTH[0];
            command[3] = COMMAND_LENGTH[1];
            command[4] = COMMAND_LENGTH[2];
            command[5] = TYPE;
            command[6] = CODE;
            command[7] = TAIL;
            return command;
        }
    }

    class Comman_Config : Command_Composer
    {
        /// <summary>传输模式</summary>
        private byte transMode = 0x00;
        /// <summary>软增益，低位在前</summary>
        private byte[] soft_amplify = new byte[4]{ 0x00, 0x00, 0x00, 0x00 };
        /// <summary>硬增益，取值为1~8</summary>
        private byte hard_amplify = 0x01;
        /// <summary>时间常数</summary>
        private byte[] timeCoeff = new byte[4]{ 0x00, 0x00, 0x00, 0x00 };
        /// <summary>成形时间</summary>
        private byte constructTime = 0x01;
        /// <summary>快通道触发阈值</summary>
        private byte[] fastThresh = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        /// <summary>平顶移位</summary>
        private byte flattopShift = 0x00;
        /// <summary>上升时间</summary>
        private byte riseTime = 0x00;
        /// <summary>平顶时间</summary>
        private byte flattopTime = 0x00;
        /// <summary>极零相消值</summary>
        private byte[] pzCancellation;
        /// <summary>α、β上升时间区分值</summary>
        private byte[] risetimeDiff = new byte[2] { 0x00, 0x00 };
        /// <summary>预留9个字节</summary>
        private byte[] extraInfo = new byte[9];
        /// <summary>CRC校验码</summary>
        private byte[] crcCode = new byte[2];

        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Comman_Config()
        {
            DATA_LENGTH = 38;
            TOTAL_LENGTH = 41;
            TYPE = 0xA2;
            CODE = 0x14;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 传输模式属性
        /// </summary>
        public byte TRANSMODE
        {
            get { return transMode; }
            set { transMode = value; }
        }

        /// <summary>
        /// 软件增益属性
        /// </summary>
        public byte[] SOFT_AMP
        {
            get { return soft_amplify; }
            set { soft_amplify = value; }
        }

        /// <summary>
        /// 硬件增益属性
        /// </summary>
        public byte HARD_AMP
        {
            get { return hard_amplify; }
            set { hard_amplify = value; }
        }

        /// <summary>
        /// 时间常数属性
        /// </summary>
        public byte[] TIME_COEFF
        {
            get { return timeCoeff; }
            set { timeCoeff = value; }
        }

        /// <summary>
        /// 成形时间属性
        /// </summary>
        public byte CONSTRUCT_TIME 
        {
            get { return constructTime; }
            set { constructTime = value; }
        }

        /// <summary>
        /// 快通道触发阈值属性
        /// </summary>
        public byte[] FAST_THRESH
        {
            get { return fastThresh; }
            set { fastThresh = value; }
        }

        /// <summary>
        /// 平顶移位属性
        /// </summary>
        public byte FLATTOP_SHIFT
        {
            get { return flattopShift; }
            set { flattopShift = value; }
        }

        /// <summary>
        /// 上升时间属性
        /// </summary>
        public byte RISETIME
        {
            get { return riseTime; }
            set { riseTime = value; }
        }

        /// <summary>
        /// 平顶时间属性
        /// </summary>
        public byte FLATTOP_TIME
        {
            get { return flattopTime; }
            set { flattopTime = value; }
        }
        
        /// <summary>
        /// 极零相消属性
        /// </summary>
        public byte[] PZ_CANCELL
        {
            get { return pzCancellation; }
            set { pzCancellation = value; }
        }

        /// <summary>
        /// 上升时间区分值属性
        /// </summary>
        public byte[] RISTTIME_DIFF
        {
            get { return risetimeDiff; }
            set { risetimeDiff = value; }
        }

        /// <summary>
        /// 预留数据属性
        /// </summary>
        public byte[] EXTRA_INFO
        {
            get { return extraInfo; }
            set { extraInfo = value; }
        }

        /// <summary>
        /// CRC验证码属性
        /// </summary>
        public byte[] CRC_CODE
        {
            get { return crcCode; }
            set { crcCode = value; }
        }

        /// <summary>
        /// 获取复位并重启测量命令
        /// </summary>
        /// <returns>复位令字节序列</returns>
        public override byte[] get_command()
        {
            byte[] command = new byte[TOTAL_LENGTH];
            // 填充命令字节序列
            command[0] = HEAD[0];
            command[1] = HEAD[1];
            command[2] = COMMAND_LENGTH[0];
            command[3] = COMMAND_LENGTH[1];
            command[4] = COMMAND_LENGTH[2];
            command[5] = TYPE;
            command[6] = CODE;
            command[7] = TRANSMODE;
            command[8] = SOFT_AMP[0];
            command[9] = SOFT_AMP[1];
            command[10] = SOFT_AMP[2];
            command[11] = SOFT_AMP[3];
            command[12] = HARD_AMP;
            command[13] = TIME_COEFF[0];
            command[14] = TIME_COEFF[1];
            command[15] = TIME_COEFF[2];
            command[16] = TIME_COEFF[3];
            command[17] = CONSTRUCT_TIME;
            command[18] = FAST_THRESH[0];
            command[19] = FAST_THRESH[1];
            command[20] = FAST_THRESH[2];
            command[21] = FAST_THRESH[3];
            command[22] = FLATTOP_SHIFT;
            command[23] = RISETIME;
            command[24] = FLATTOP_TIME;
            command[25] = PZ_CANCELL[0];
            command[26] = PZ_CANCELL[1];
            command[27] = RISTTIME_DIFF[0];
            command[28] = RISTTIME_DIFF[1];
            command[29] = EXTRA_INFO[0];
            command[30] = EXTRA_INFO[1];
            command[31] = EXTRA_INFO[2];
            command[32] = EXTRA_INFO[3];
            command[33] = EXTRA_INFO[4];
            command[34] = EXTRA_INFO[5];
            command[35] = EXTRA_INFO[6];
            command[36] = EXTRA_INFO[7];
            command[37] = EXTRA_INFO[8];
            command[38] = CRC_CODE[0];
            command[39] = CRC_CODE[1];
            command[40] = TAIL;

            return command;
        }
    }

    class Comman_Hardware : Command_Composer
    {
        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        public Comman_Hardware()
        {
            DATA_LENGTH = 26;
            TOTAL_LENGTH = 29;
            TYPE = 0xA2;
            CODE = 0x15;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 获取复位并重启测量命令
        /// </summary>
        /// <returns>复位令字节序列</returns>
        public override byte[] get_command()
        {
            byte[] command = new byte[TOTAL_LENGTH];
            // 填充命令字节序列
            command[0] = HEAD[0];
            command[1] = HEAD[1];
            command[2] = COMMAND_LENGTH[0];
            command[3] = COMMAND_LENGTH[1];
            command[4] = COMMAND_LENGTH[2];
            command[5] = TYPE;
            command[6] = CODE;
            command[7] = TAIL;
            return command;
        }
    }
}
