// ***********************************************************************
// 文件名(File Name):            command_interpreter.cs
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
    class Message_Interpreter
    {
                /// <summary>祯头:两个字节，固定格式 0x3a,0xa3</summary>
        private byte[] validHead = new byte[]{0x3a, 0xa3};
        /// <summary>祯尾:一个字节，固定格式0xc3</summary>
        private byte validTail = 0xc3;
        /// <summary>命令类型：不确定</summary>
        private byte commandType = 0x00;
        /// <summary>命令码：不确定</summary>
        private byte commandCode = 0x00;
        /// <summary>命令序列总字节数</summary>
        private int totalCount = 0;
        /// <summary>命令内容总字节数</summary>
        private int contentCount = 0;
        /// <summary>命令字节序列</summary>
        private byte[] contents = new byte[]{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00};
        /// <summary>构造成功标志位</summary>
        private bool successFlag = false;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Message_Interpreter()
        {
            
        }

        /// <summary>
        /// 构造函数，由十六进制字节序列初始化命令内容
        /// </summary>
        /// <param name="msg">十六进制字节序列</param>
        public Message_Interpreter(byte[] sequence)
        {
            successFlag = Validate_Sequence(sequence);      // 验证序列是否正常
            if(successFlag)
            {
                contents = sequence;                        // 将传入的字节序列赋值给命令字节序列
                totalCount = contents.Length;               // 初始化命令内容字节数
            }
        }
        
        /// <summary>
        /// 构造函数，由字符串初始化命令内容
        /// </summary>
        /// <param name="msg">字符串命令序列</param>
        /// <param name="msg"></param>
        public Message_Interpreter(string msg)
        {
            byte[] sequence = Encoding.Default.GetBytes(msg);   // 将输入字符串序列转换为字节序列
            successFlag = Validate_Sequence(sequence);          // 验证序列是否正常
            if (successFlag)
            {
                contents = sequence;                            // 将转换后的字节序列赋值给命令字节序列
                totalCount = contents.Length;                   // 初始化命令内容字节数
            }
        }

        /// <summary>
        /// 检验命令祯头祯尾是否正常
        /// </summary>
        /// <param name="sequence">
        /// 输入的字节序列
        /// </param>
        /// <returns>
        /// 判断状态，false代表异常，true代表正常
        /// </returns>
        private bool Validate_Sequence(byte[] sequence)
        {
            int commandLength = sequence.Length;
            // 命令总字节数必定大于等于8
            if (commandLength >= 8)
            {
                if (sequence[0] == validHead[0] &&
                    sequence[1] == validHead[1] &&
                    sequence[commandLength - 1] == validTail)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据命令中的数据总长度，计算命令内容长度
        /// </summary>
        /// <returns>命令内容长度</returns>
        private int get_contents_length()
        {
            byte lowByte = contents[2];
            byte midByte = contents[3];
            byte highByte = contents[4];

            int count = lowByte + midByte * 256 + highByte * 256 * 256;
            return count;
        }

        /// <summary>
        /// 构造成功标志位属性
        /// </summary>
        public bool Succsess
        {
            get {return successFlag; }
            set { successFlag = value; }
        }

        public byte[] Contents
        {
            get { return contents; }
            set { contents = value; }
        }
    }
}
