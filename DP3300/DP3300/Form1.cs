using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DP3300
{
    public partial class form_main : Form
    {
        /// <summary>组播对象</summary>
        private M_Multi_Cast multi_cast = new M_Multi_Cast("238.228.218.208",12321,"10.10.100.100",6000);
        /// <summary>服务器对象</summary>
        private M_Tcp_Server tcp_server = new M_Tcp_Server("10.10.100.100", 6000);
        
        private int trans_mode_index = 0;           // 界面控件传输模式选择索引
        private int hard_amp_index = 0;             // 界面控件硬件增益选择索引
        private int soft_amp_value = 0;             // 界面控件软件增益设置值
        private double time_coeff_value = 0.0;      // 界面控件时间常数设置值
        private int form_time_index = 0;            // 界面控件成形时间选择索引
        private int fast_channel_trig_value = 60;   // 界面控件快速通道触发阈值设置值
        private int channel_num_index = 0;          // 界面控件通道数选择索引

        private int direct_shift_value = 800;       // 界面控件直流偏置设置值
        private bool input_decay_on = false;        // 界面控件输入衰减使能标志位
        private bool polar_positive = false;        // 界面控件输入极性选择标志位
        private bool cr_deriv_on = false;           // 界面控件CR微分使能标志位
        
        private int energy_range_value = 1024;            // 界面控件能量范围设置值
        private int am_area_ratio_value = 15;             // 界面控件AM峰面积比例设置值
        private double peak_correct_coeff_value = 20;     // 界面控件峰位校正系数设置值

        private int high_voltage_value = 0;               // 界面控件高压调节设置值
        private int spec_refresh_interval = 1;            // 界面控件刷新事件间隔设置值
        private int measure_time_seconds_value = 10;      // 界面控件测量时间长度设置值
        private int measure_times_value = 10;             // 界面控件测量次数设置值

        /// <summary>
        /// 界面控件初始化
        /// </summary>
        public form_main()
        {
            InitializeComponent();
            // 设置默认值            
            cb_trans_mode.SelectedIndex = this.trans_mode_index;
            cb_hard_amp.SelectedIndex = this.hard_amp_index;
            tb_soft_amp.Text = this.soft_amp_value.ToString();
            tb_time_coeff.Text = this.time_coeff_value.ToString();
            cb_form_time.SelectedIndex = this.form_time_index;
            tb_fast_channel_trig_thresh.Text = this.fast_channel_trig_value.ToString();
            cb_spectrum_channel_num.SelectedIndex = this.channel_num_index;

            tb_direct_shift.Text = this.direct_shift_value.ToString();
            rb_CR_deriv_on.Checked = this.cr_deriv_on;
            rb_input_decay_on.Checked = this.input_decay_on;
            rb_input_polar_positive.Checked = this.polar_positive;

            tb_energy_range.Text = this.energy_range_value.ToString();
            tb_am_peak_area_ratio.Text = this.am_area_ratio_value.ToString();
            tb_peak_correct_coeff.Text = this.peak_correct_coeff_value.ToString();

            tb_high_voltage.Text = this.high_voltage_value.ToString();
            tb_spec_refresh_interval.Text = this.spec_refresh_interval.ToString();
            tb_measure_time_seconds.Text = this.measure_time_seconds_value.ToString();
            tb_total_measure_times.Text = this.measure_times_value.ToString();
        }

        /// <summary>
        /// 将字符串转换为十六进制数组
        /// </summary>
        /// <param name="source_str">输入的字符串</param>
        /// <returns>计算后的十六进制数组</returns>
        private byte[] strToHexByte(string source_str)
        {
            source_str = source_str.Replace(" ", "");
            if ((source_str.Length % 2) != 0)
                source_str += " ";
            byte[] result = new byte[source_str.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(source_str.Substring(i * 2, 2), 16);
            }

            return result;
        }

        /// <summary>
        /// 十六进制数组转字符串
        /// </summary>
        /// <param name="hexbytes"></param>
        /// <returns></returns>
        private string hexBytesTostr(byte[] hexbytes)
        {
            string result = "";
            if (hexbytes != null)
            {
                for (int i = 0; i < hexbytes.Length; i++)
                {
                    result += hexbytes[i].ToString("X2")+" ";
                }
            }

            return result;
        }

        /// <summary>
        /// 连接设备按钮事件响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_connect_device_Click(object sender, EventArgs e)
        {
            tcp_server.start();
            bool connect_success = tcp_server.wait_connect_in_seconds(5);
            multi_cast.send_command();
            if (connect_success)
            {
                rtb_received_message.Text = "设备连接成功";
                gb_device_connect.Enabled = false;
                gb_param_config.Enabled = true;
                gb_device_operate.Enabled = true;
            }
        }

        /// <summary>
        /// 命令发送窗口清空按事件钮响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_clear_send_command_Click(object sender, EventArgs e)
        {
            rtb_send_command.Clear();
        }

        /// <summary>
        /// 命令发送按钮事件响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_send_command_Click(object sender, EventArgs e)
        {
            string rtb_content = rtb_send_command.Text;
            byte[] command = strToHexByte(rtb_content);
            tcp_server.send_command(command);

            rtb_received_message.Clear();
            byte[] answer = tcp_server.get_ack();
            string message = hexBytesTostr(answer);
            rtb_received_message.Text = message;
        }

        /// <summary>
        /// 设备参数设置按钮事件响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_device_config_Click(object sender, EventArgs e)
        {
            Command_Config command_config = new Command_Config();
        }

        /// <summary>
        /// 设备输入信号特性配置按钮事件响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_input_feature_config_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 高压调节按钮事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_high_voltage_config_Click(object sender, EventArgs e)
        {
            Command_HighVoltage high_voltage_command_composer = new Command_HighVoltage();
            byte[] command = high_voltage_command_composer.get_command();
            tcp_server.send_command(command);
        }

        /// <summary>
        /// 停止测量按钮事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_stop_measure_Click(object sender, EventArgs e)
        {
            Command_Stop stop_command_composer = new Command_Stop();
            byte[] command = stop_command_composer.get_command();
            tcp_server.send_command(command);
        }

        /// <summary>
        /// 启动测量按钮事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_start_measure_Click(object sender, EventArgs e)
        {
            Command_Start start_command_composer = new Command_Start();
            byte[] command = start_command_composer.get_command();
            tcp_server.send_command(command);
        }

        /// <summary>
        /// 获取谱线按钮事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_extract_spectrum_data_Click(object sender, EventArgs e)
        {
            Command_Get_Multi_Channel extract_data_command_composer = new Command_Get_Multi_Channel();
            byte[] command = extract_data_command_composer.get_command();
            tcp_server.send_command(command);
        }

        /// <summary>
        /// 传输模式选择变更事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_trans_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.trans_mode_index = cb_trans_mode.SelectedIndex;
        }

        /// <summary>
        /// 硬件增益选项更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_hard_amp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hard_amp_index = cb_hard_amp.SelectedIndex;
        }

        /// <summary>
        /// 软件增益数值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_soft_amp_TextChanged(object sender, EventArgs e)
        {
            this.soft_amp_value = System.Convert.ToInt32(tb_soft_amp.Text);
        }

        /// <summary>
        /// 时间常数数值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_time_coeff_TextChanged(object sender, EventArgs e)
        {
            this.time_coeff_value = System.Convert.ToDouble(tb_time_coeff.Text);
        }

        /// <summary>
        /// 快速通道触发阈值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_fast_channel_trig_thresh_TextChanged(object sender, EventArgs e)
        {
            this.fast_channel_trig_value = System.Convert.ToInt32("12"); //tb_fast_channel_trig_thresh.Text
        }

        /// <summary>
        /// 成形时间选项变更事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_form_time_SelectedValueChanged(object sender, EventArgs e)
        {
            this.form_time_index = cb_form_time.SelectedIndex;
        }

        /// <summary>
        /// 能谱通道数量选项变更事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_spectrum_channel_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.channel_num_index = cb_spectrum_channel_num.SelectedIndex;
        }

        /// <summary>
        /// 直流偏置设定值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_direct_shift_TextChanged(object sender, EventArgs e)
        {
            this.direct_shift_value = System.Convert.ToInt32(tb_direct_shift.Text);
        }

        /// <summary>
        /// 输入衰减选定项更改时间处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_input_decay_on_CheckedChanged(object sender, EventArgs e)
        {
            this.input_decay_on = rb_input_decay_on.Checked;
        }

        /// <summary>
        /// CR微分模式选项更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_CR_deriv_on_CheckedChanged(object sender, EventArgs e)
        {
            this.cr_deriv_on = rb_CR_deriv_on.Checked;
        }

        /// <summary>
        /// 输入信号极性更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_input_polar_positive_CheckedChanged(object sender, EventArgs e)
        {
            this.polar_positive = rb_input_polar_positive.Checked;
        }

        /// <summary>
        /// 能量范围设置值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_energy_range_TextChanged(object sender, EventArgs e)
        {
            this.energy_range_value = System.Convert.ToInt32(tb_energy_range.Text);
        }

        /// <summary>
        /// 谱线刷新间隔时间设定值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_spec_refresh_interval_TextChanged(object sender, EventArgs e)
        {
            this.spec_refresh_interval = System.Convert.ToInt32(tb_spec_refresh_interval.Text);
        }

        /// <summary>
        /// 测量时间设定值更改时间处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_measure_time_seconds_TextChanged(object sender, EventArgs e)
        {
            this.measure_time_seconds_value = System.Convert.ToInt32(tb_measure_time_seconds.Text);
        }

        /// <summary>
        /// 测量次数设定值更改事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_total_measure_times_TextChanged(object sender, EventArgs e)
        {
            this.measure_times_value = System.Convert.ToInt32(tb_total_measure_times.Text);
        }
    }
}
