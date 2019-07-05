// ***********************************************************************
// 文件名(File Name):            Command_Composer.cs
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
    /// <summary>
    /// 命令合成基类
    /// </summary>
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

    /// <summary>
    /// 侦测/握手命令类
    /// </summary>
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

    /// <summary>
    /// 复位重启命令类
    /// </summary>
    class Command_Reset : Command_Composer
    {
        /// <summary>
        /// 构造函数，初始化复位重启命令属性值
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

    /// <summary>
    /// 获取多道数据命令类
    /// </summary>
    class Command_Get_Multi_Channel : Command_Composer
    {
        /// <summary>命令内容</summary>
        private byte command_content = 0x00;

        /// <summary>
        /// 构造函数，初始化获取多道数据命令属性值
        /// </summary>
        public Command_Get_Multi_Channel()
        {
            DATA_LENGTH = 6;
            TOTAL_LENGTH = 9;
            TYPE = 0xA2;
            CODE = 0x12;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 构造函数，初始化侦测命令属性值
        /// </summary>
        /// <param name="num">指定通道数</param>
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
        /// 获取多道数据命令
        /// </summary>
        /// <returns>获取多道数据命令字节序列</returns>
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

    /// <summary>
    /// 停止测量命令类
    /// </summary>
    class Command_Stop : Command_Composer
    { 
        /// <summary>
        /// 构造函数，初始化停止测量命令属性值
        /// </summary>
        public Command_Stop()
        {
            DATA_LENGTH = 5;
            TYPE = 0xA2;
            CODE = 0x13;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 获取停止测量命令
        /// </summary>
        /// <returns>停止测量命令字节序列</returns>
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

    /// <summary>
    /// 配置命令类
    /// </summary>
    class Command_Config : Command_Composer
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
        private byte[] pzCancellation = new byte[]{ 0x00, 0x00 };
        /// <summary>α、β上升时间区分值</summary>
        private byte[] risetimeDiff = new byte[2] { 0x00, 0x00 };
        /// <summary>预留9个字节</summary>
        private byte[] extraInfo = new byte[9];
        /// <summary>CRC校验码</summary>
        private byte[] crcCode = new byte[2];

        /// <summary>
        /// 构造函数，初始化参数配置命令属性值
        /// </summary>
        public Command_Config()
        {
            DATA_LENGTH = 38;
            TOTAL_LENGTH = 41;
            TYPE = 0xA2;
            CODE = 0x14;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 传输模式属性
        /// 0 表示传输谱线
        /// 1 表示传输成形后的信号波形
        /// 2 表示传输原始指数信号
        /// 3 表示粒子模式
        /// 4 表示α、β测量模式
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
        /// 取值范围从1~8，参考硬件手册
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
        /// 取值范围1~18，表示成形时间从2us到36us
        /// </summary>
        public byte CONSTRUCT_TIME 
        {
            get { return constructTime; }
            set { constructTime = value; }
        }

        /// <summary>
        /// 快通道触发阈值属性
        /// 单位0.1mV,100表示10mV
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
        /// 单位为k*ns
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
        /// 获取参数配置命令
        /// </summary>
        /// <returns>参数配置命令字节序列</returns>
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

    /// <summary>
    /// 硬件调节控制类
    /// </summary>
    class Command_Hardware : Command_Composer
    {
        /// <summary>衰减控制标志位</summary>
        private byte decayFlag = 0x00;
        /// <summary>CR微分模式启用标志位</summary>
        private byte crderiveMode = 0x00;
        /// <summary>输入信号极性选择</summary>
        private byte polar = 0x00;
        /// <summary>直流偏移量</summary>
        private byte[] directShift = new byte[4] { 0x00, 0x00, 0x00, 0x00 };
        /// <summary>预留数据位</summary>
        private byte[] extraInfo = new byte[12] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        /// <summary>CRC校验码</summary>
        private byte[] crcCode = new byte[] { 0x00, 0x00 };

        /// <summary>
        /// 构造函数，初始化硬件调节控制属性值
        /// </summary>
        public Command_Hardware()
        {
            DATA_LENGTH = 26;
            TOTAL_LENGTH = 29;
            TYPE = 0xA2;
            CODE = 0x15;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 12V输入信号衰减启用属性
        /// 0 代表关闭
        /// 1 代表启用
        /// </summary>
        public byte DECAY_MODE
        {
            get { return decayFlag; }
            set { decayFlag = value; }
        }

        /// <summary>
        /// CR微分模式启用属性
        /// 0 表示关闭
        /// 1 表示启用
        /// </summary>
        public byte CR_DERIVE_MODE
        {
            get { return crderiveMode; }
            set { crderiveMode = value; }
        }

        /// <summary>
        /// 输入信号正负极性属性
        /// 0 表示负信号
        /// 1 表示正信号
        /// </summary>
        public byte POLAR
        {
            get { return polar; }
            set { polar = value; }
        }

        /// <summary>
        /// 直流偏移属性
        /// 单位为mV
        /// 4字节int型数据
        /// </summary>
        public byte[] DIRECT_SHIFT
        {
            get { return directShift; }
            set { directShift = value; }
        }

        /// <summary>
        /// 预留数据位属性
        /// </summary>
        public byte[] EXTRA_INFO
        {
            get { return extraInfo; }
            set { extraInfo = value; }
        }

        /// <summary>
        /// CRC校验码属性
        /// </summary>
        public byte[] CRC_CODE
        {
            get { return crcCode; }
            set { crcCode = value; }
        }

        /// <summary>
        /// 获取硬件调节控制命令
        /// </summary>
        /// <returns>硬件调节控制命令字节序列</returns>
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
            command[7] = DECAY_MODE;
            command[8] = CR_DERIVE_MODE;
            command[9] = POLAR;
            command[10] = DIRECT_SHIFT[0];
            command[11] = DIRECT_SHIFT[1];
            command[12] = DIRECT_SHIFT[2];
            command[13] = DIRECT_SHIFT[3];
            command[14] = EXTRA_INFO[0];
            command[15] = EXTRA_INFO[1];
            command[16] = EXTRA_INFO[2];
            command[17] = EXTRA_INFO[3];
            command[18] = EXTRA_INFO[4];
            command[19] = EXTRA_INFO[5];
            command[20] = EXTRA_INFO[6];
            command[21] = EXTRA_INFO[7];
            command[22] = EXTRA_INFO[8];
            command[23] = EXTRA_INFO[9];
            command[24] = EXTRA_INFO[10];
            command[25] = EXTRA_INFO[11];
            command[26] = CRC_CODE[0];
            command[27] = CRC_CODE[1];
            command[28] = TAIL;
            return command;
        }
    }

    /// <summary>
    /// 高压控制命令类
    /// </summary>
    class Command_HighVoltage : Command_Composer
    {
        /// <summary>设定高压值</summary>
        private byte[] highVoltage = new byte[2] { 0x00, 0x00 };

        /// <summary>
        /// 构造函数，初始化高压控制命令属性值
        /// </summary>
        public Command_HighVoltage()
        {
            DATA_LENGTH = 7;
            TOTAL_LENGTH = 10;
            TYPE = 0xA2;
            CODE = 0x16;
            set_content_length(DATA_LENGTH);
        }

        public Command_HighVoltage(int voltage)
        {
            DATA_LENGTH = 7;
            TOTAL_LENGTH = 10;
            TYPE = 0xA2;
            CODE = 0x16;
            set_content_length(DATA_LENGTH);

            byte[] vol_bytes = BitConverter.GetBytes(voltage);
            HIGH_VOLTATGE[0] = vol_bytes[0];
            HIGH_VOLTATGE[0] = vol_bytes[2];
        }

        /// <summary>
        /// 高压设定值属性，2字节
        /// 0 表示关闭高压
        /// 1~5000为设定高压值
        /// </summary>
        public byte[] HIGH_VOLTATGE
        {
            get { return highVoltage; }
            set { highVoltage = value; }
        }

        /// <summary>
        /// 获取高压控制命令
        /// </summary>
        /// <returns>硬件高压控制命令字节序列</returns>
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
            command[7] = HIGH_VOLTATGE[0];
            command[8] = HIGH_VOLTATGE[1];
            command[9] = TAIL;
            return command;
        }
    }

    /// <summary>
    /// 自动稳谱命令类
    /// </summary>
    class Command_Auto_Spec : Command_Composer
    {
        /// <summary>设定最大能量范围</summary>
        private byte[] energyMax = new byte[4] { 0x00, 0x00, 0x00, 0x00 };

        /// <summary>
        /// 构造函数，初始化高压控制命令属性值
        /// </summary>
        public Command_Auto_Spec()
        {
            DATA_LENGTH = 9;
            TOTAL_LENGTH = 12;
            TYPE = 0xA2;
            CODE = 0x17;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 高压设定值属性,4字节
        /// 0 表示关闭高压
        /// 1~5000为设定高压值
        /// </summary>
        public byte[] ENERGY_MAX
        {
            get { return energyMax; }
            set { energyMax = value; }
        }

        /// <summary>
        /// 获取自动稳谱命令
        /// </summary>
        /// <returns>硬自动稳谱命令字节序列</returns>
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
            command[7] = ENERGY_MAX[0];
            command[8] = ENERGY_MAX[1];
            command[9] = ENERGY_MAX[2];
            command[10] = ENERGY_MAX[3];
            command[11] = TAIL;
            return command;
        }
    }

    /// <summary>
    /// 存Flash类
    /// </summary>
    class Command_Save_Flash : Command_Composer
    {
        /// <summary>读写标志位</summary>
        private byte rwFlag = 0x00;
        /// <summary>峰面积寻峰法的面积比例</summary>
        private byte[] amRatio = new byte[] { 0x00, 0x00 };
        /// <summary>峰位校正系数</summary>
        private byte[] correctCoeff = new byte[] { 0x00, 0x00, 0x00, 0x00 };

        /// <summary>
        /// 构造函数，初始化存FLASH命令属性值
        /// </summary>
        public Command_Save_Flash()
        {
            DATA_LENGTH = 12;
            TOTAL_LENGTH = 15;
            TYPE = 0xA2;
            CODE = 0x18;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 读写标志位属性
        /// 0 表示读
        /// 1 表示写
        /// </summary>
        public byte RW_FLAG
        {
            get { return rwFlag; }
            set { rwFlag = value; }
        }

        /// <summary>
        /// 峰面积比例属性
        /// 例如15代表15%
        /// </summary>
        public byte[] AM_RATIO
        {
            get { return amRatio; }
            set { amRatio = value; }
        }

        /// <summary>
        /// 峰位校正系数属性
        /// 例如24500代表换算系数为24.500
        /// </summary>
        public byte[] CORRECT_COEF
        {
            get { return correctCoeff; }
            set { correctCoeff = value; }
        }

        /// <summary>
        /// 获取存FLASH命令
        /// </summary>
        /// <returns>存FLASH命令字节序列</returns>
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
            command[7] = RW_FLAG;
            command[8] = AM_RATIO[0];
            command[9] = AM_RATIO[1];
            command[10] = CORRECT_COEF[0];
            command[11] = CORRECT_COEF[1];
            command[12] = CORRECT_COEF[2];
            command[13] = CORRECT_COEF[3];
            command[14] = TAIL;
            return command;
        }
    }

    /// <summary>
    /// 查询系统信息命令类
    /// </summary>
    class Command_Query_SysInfo : Command_Composer
    { 
            /// <summary>
        /// 构造函数，初始化获取系统信息命令属性值
        /// </summary>
        public Command_Query_SysInfo()
        {
            DATA_LENGTH = 5;
            TYPE = 0xA0;
            CODE = 0x80;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 获取停止测量命令
        /// </summary>
        /// <returns>停止测量命令字节序列</returns>
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

    /// <summary>
    /// 开始测量命令
    /// </summary>
    class Command_Start : Command_Composer
    {
        /// <summary>通道0~63</summary>
        private byte channel = 0x01;

        /// <summary>
        /// 构造函数，初始化获取系统信息命令属性值
        /// </summary>
        public Command_Start()
        {
            DATA_LENGTH = 6;
            TOTAL_LENGTH = 9;
            TYPE = 0xA6;
            CODE = 0xA4;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 测量通道属性
        /// </summary>
        public byte MEASURE_CHANNEL
        {
            get { return channel; }
            set { channel = value; }
        }

        /// <summary>
        /// 获取开始测量命令
        /// </summary>
        /// <returns>开始测量命令字节序列</returns>
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
            command[7] = MEASURE_CHANNEL;
            command[8] = TAIL;
            return command;
        }
    }

    /// <summary>
    /// 快速参数配置命令类
    /// </summary>
    class Command_Fast_Config : Command_Composer
    {
        /// <summary>通道数</summary>
        private byte channel = 0x00;
        /// <summary>祯头</summary>
        private byte contentHead = 0xE2;
        /// <summary>预留数据位</summary>
        private byte[] extraConfig = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        /// <summary>直流偏移</summary>
        private byte[] directShift = new byte[] { 0x00, 0x00 };
        /// <summary>极性、衰减、CR</summary>
        private byte polarFlag = 0x00;
        /// <summary>数据传输模式</summary>
        private byte transMode = 0x00;
        /// <summary>软件增益</summary>
        private byte[] softAmp = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        /// <summary>硬增益值</summary>
        private byte hardAmp = 0x00;
        /// <summary>时间常数</summary>
        private byte[] timeCoeff = new byte[] { 0x00, 0x00 };
        /// <summary>成形时间</summary>
        private byte buildTime = 0x00;
        /// <summary>快通道出发阈值，3字节</summary>
        private byte[] fastchannelThres = new byte[] { 0x00, 0x00, 0x00 };
        /// <summary>预留数据位，35字节</summary>
        private byte[] extraData = new byte[35];

        /// <summary>
        /// 默认构造函数，设置关键变量默认值
        /// </summary>
        public Command_Fast_Config()
        {
            DATA_LENGTH = 61;
            TOTAL_LENGTH = 64;
            TYPE = 0xA6;
            CODE = 0xA1;
            set_content_length(DATA_LENGTH);
        }

        /// <summary>
        /// 内容祯头属性
        /// </summary>
        public byte CONTENT_HEAD
        {
            get { return contentHead; }
            set { contentHead = value; }
        }

        /// <summary>
        /// 测量通道属性,1字节，0~63通道
        /// </summary>
        public byte CHANNEL
        {
            get { return channel; }
            set { channel = value; }
        }

        /// <summary>
        /// 直流偏移属性，2字节，单位mV
        /// </summary>
        public byte[] DIRECT_SHIFT
        {
            get { return directShift; }
            set { directShift = value; }
        }

        /// <summary>
        /// 极性、衰减及CR属性，0bit极性翻转,1bit输入衰减,2bit复位CR
        /// </summary>
        public byte BIT_MODE
        {
            get { return polarFlag; }
            set { polarFlag = value; }
        }

        /// <summary>
        /// 硬件配置属性,0bit极性翻转
        /// </summary>
        public bool POLAR_REVERSE
        {
            get 
            { 
                byte temp = (byte)(polarFlag & 0x01);
                return temp == 0x01;
            }
            set
            {
                byte temp = (byte)((value == false) ? 0x00 : 0x01);
                polarFlag |= temp;
            }
        }

        /// <summary>
        /// 硬件配置属性,1bit输入衰减
        /// </summary>
        public bool DECAY_FLAG
        {
            get
            {
                byte temp = (byte)(polarFlag & 0x02);
                return temp == 0x02;
            }
            set
            {
                byte temp = (byte)((value == false) ? 0x00 : 0x02);
                polarFlag |= temp;
            }
        }

        /// <summary>
        /// 硬件配置属性,2bit复位CR 
        /// </summary>
        public bool CR_FLAG
        {
            get
            {
                byte temp = (byte)(polarFlag & 0x04);
                return temp == 0x04;
            }
            set
            {
                byte temp = (byte)((value == false) ? 0x00 : 0x04);
                polarFlag |= temp;
            }
        }

        /// <summary>
        /// 传输模式属性，0能谱采集，1成形谱，2原始谱，3粒子模式
        /// </summary>
        public byte TRANS_MODE
        {
            get { return transMode; }
            set { transMode = value; }
        }

        /// <summary>
        /// 软件增益属性，4字节
        /// </summary>
        public byte[] SOFT_AMP
        {
            get { return softAmp; }
            set { softAmp = value; }
        }

        /// <summary>
        /// 硬增益值属性，从1到8表示8个档位
        /// </summary>
        public byte HARD_AMP
        {
            get { return hardAmp; }
            set { hardAmp = value; }
        }

        /// <summary>
        /// 时间常数属性，2字节
        /// M = Tf/12.5,如Tf为3.2us，M=3.2*1000/12.5=256
        /// </summary>
        public byte[] TIME_COEFF
        {
            get { return timeCoeff; }
            set { timeCoeff = value; }
        }

        /// <summary>
        /// 成形时间属性，1到18表示从2us到36us
        /// </summary>
        public byte BUILD_TIME
        {
            get { return buildTime; }
            set { buildTime = value; }
        }

        /// <summary>
        /// 快速通道出发阈值属性，3字节，单位0.1mV
        /// </summary>
        public byte[] FAST_CHANNEL_THRES
        {
            get { return fastchannelThres; }
            set { fastchannelThres = value; }
        }

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
            command[7] = CHANNEL;
            command[8] = CONTENT_HEAD;
            command[9] = extraConfig[0];
            command[10] = extraConfig[1];
            command[11] = extraConfig[2];
            command[12] = extraConfig[3];
            command[13] = DIRECT_SHIFT[0];
            command[14] = DIRECT_SHIFT[1];
            command[15] = BIT_MODE;
            command[16] = TRANS_MODE;
            command[17] = SOFT_AMP[0];
            command[18] = SOFT_AMP[1];
            command[19] = SOFT_AMP[2];
            command[20] = SOFT_AMP[3];
            command[21] = HARD_AMP;
            command[22] = TIME_COEFF[0];
            command[23] = TIME_COEFF[1];
            command[24] = BUILD_TIME;
            command[25] = FAST_CHANNEL_THRES[0];
            command[26] = FAST_CHANNEL_THRES[1];
            command[27] = FAST_CHANNEL_THRES[2];
            command[28] = 0x00;
            command[29] = 0x00;
            command[30] = 0x00;
            command[31] = 0x00;
            command[32] = 0x00;
            command[33] = 0x00;
            command[34] = 0x00;
            command[35] = 0x00;
            command[36] = 0x00;
            command[37] = 0x00;
            command[38] = 0x00;
            command[39] = 0x00;
            command[40] = 0x00;
            command[41] = 0x00;
            command[42] = 0x00;
            command[43] = 0x00;
            command[44] = 0x00;
            command[45] = 0x00;
            command[46] = 0x00;
            command[47] = 0x00;
            command[48] = 0x00;
            command[49] = 0x00;
            command[50] = 0x00;
            command[51] = 0x00;
            command[52] = 0x00;
            command[53] = 0x00;
            command[54] = 0x00;
            command[55] = 0x00;
            command[56] = 0x00;
            command[57] = 0x00;
            command[58] = 0x00;
            command[59] = 0x00;
            command[60] = 0x00;
            command[61] = 0x00;
            command[62] = 0x00;
            command[63] = TAIL;
            return command;
        }
    }
}
