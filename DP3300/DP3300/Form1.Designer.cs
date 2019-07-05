namespace DP3300
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_connect_device = new System.Windows.Forms.Button();
            this.label_trans_mode = new System.Windows.Forms.Label();
            this.label_hard_amp = new System.Windows.Forms.Label();
            this.label_soft_amp = new System.Windows.Forms.Label();
            this.label_time_coeff = new System.Windows.Forms.Label();
            this.label_form_time = new System.Windows.Forms.Label();
            this.label_fast_channel_trig_thresh = new System.Windows.Forms.Label();
            this.label_spectrum_channel_num = new System.Windows.Forms.Label();
            this.cb_trans_mode = new System.Windows.Forms.ComboBox();
            this.cb_hard_amp = new System.Windows.Forms.ComboBox();
            this.cb_form_time = new System.Windows.Forms.ComboBox();
            this.tb_time_coeff = new System.Windows.Forms.TextBox();
            this.tb_soft_amp = new System.Windows.Forms.TextBox();
            this.cb_spectrum_channel_num = new System.Windows.Forms.ComboBox();
            this.label_form_time_unit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_time_coeff_unit = new System.Windows.Forms.Label();
            this.label_multi_cast_endpoint = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_device_config = new System.Windows.Forms.Button();
            this.tb_direct_shift = new System.Windows.Forms.TextBox();
            this.label_direct_shift = new System.Windows.Forms.Label();
            this.label_direct_shift_unit = new System.Windows.Forms.Label();
            this.label_input_decay = new System.Windows.Forms.Label();
            this.label_CR_derivate = new System.Windows.Forms.Label();
            this.label_input_polar = new System.Windows.Forms.Label();
            this.rb_input_decay_on = new System.Windows.Forms.RadioButton();
            this.rb_input_decay_off = new System.Windows.Forms.RadioButton();
            this.rb_CR_deriv_off = new System.Windows.Forms.RadioButton();
            this.rb_CR_deriv_on = new System.Windows.Forms.RadioButton();
            this.rb_input_polar_negative = new System.Windows.Forms.RadioButton();
            this.rb_input_polar_positive = new System.Windows.Forms.RadioButton();
            this.bt_input_feature_config = new System.Windows.Forms.Button();
            this.label_energy_range_unit = new System.Windows.Forms.Label();
            this.tb_energy_range = new System.Windows.Forms.TextBox();
            this.label_energy_range = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_am_peak_area_ratio = new System.Windows.Forms.TextBox();
            this.label_am_peak_area_ratio = new System.Windows.Forms.Label();
            this.tb_peak_correct_coeff = new System.Windows.Forms.TextBox();
            this.label_peak_correct_coeff = new System.Windows.Forms.Label();
            this.bt_energy_range_config = new System.Windows.Forms.Button();
            this.bt_write_am_ratio = new System.Windows.Forms.Button();
            this.bt_read_pead_correct_coeff = new System.Windows.Forms.Button();
            this.tb_high_voltage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_start_measure = new System.Windows.Forms.Button();
            this.bt_extract_spectrum_data = new System.Windows.Forms.Button();
            this.bt_high_voltage_config = new System.Windows.Forms.Button();
            this.bt_stop_measure = new System.Windows.Forms.Button();
            this.bt_clear_spectrum_data = new System.Windows.Forms.Button();
            this.label_spec_refresh_interval = new System.Windows.Forms.Label();
            this.label_limit_measure_time = new System.Windows.Forms.Label();
            this.label_total_measure_count = new System.Windows.Forms.Label();
            this.tb_total_measure_times = new System.Windows.Forms.TextBox();
            this.tb_measure_time_seconds = new System.Windows.Forms.TextBox();
            this.tb_spec_refresh_interval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_device_connect = new System.Windows.Forms.GroupBox();
            this.gb_param_config = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_fast_channel_trig_thresh = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gb_device_operate = new System.Windows.Forms.GroupBox();
            this.rtb_send_command = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_clear_send_command = new System.Windows.Forms.Button();
            this.bt_send_command = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_clear_received_message = new System.Windows.Forms.Button();
            this.rtb_received_message = new System.Windows.Forms.RichTextBox();
            this.gb_device_connect.SuspendLayout();
            this.gb_param_config.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_device_operate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_connect_device
            // 
            this.bt_connect_device.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_connect_device.ForeColor = System.Drawing.Color.Red;
            this.bt_connect_device.Location = new System.Drawing.Point(219, 47);
            this.bt_connect_device.Name = "bt_connect_device";
            this.bt_connect_device.Size = new System.Drawing.Size(102, 54);
            this.bt_connect_device.TabIndex = 0;
            this.bt_connect_device.Text = "连接设备";
            this.bt_connect_device.UseVisualStyleBackColor = true;
            this.bt_connect_device.Click += new System.EventHandler(this.bt_connect_device_Click);
            // 
            // label_trans_mode
            // 
            this.label_trans_mode.AutoSize = true;
            this.label_trans_mode.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_trans_mode.Location = new System.Drawing.Point(9, 39);
            this.label_trans_mode.Name = "label_trans_mode";
            this.label_trans_mode.Size = new System.Drawing.Size(95, 19);
            this.label_trans_mode.TabIndex = 2;
            this.label_trans_mode.Text = "传输模式:";
            // 
            // label_hard_amp
            // 
            this.label_hard_amp.AutoSize = true;
            this.label_hard_amp.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_hard_amp.Location = new System.Drawing.Point(9, 73);
            this.label_hard_amp.Name = "label_hard_amp";
            this.label_hard_amp.Size = new System.Drawing.Size(95, 19);
            this.label_hard_amp.TabIndex = 4;
            this.label_hard_amp.Text = "硬件增益:";
            // 
            // label_soft_amp
            // 
            this.label_soft_amp.AutoSize = true;
            this.label_soft_amp.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_soft_amp.Location = new System.Drawing.Point(9, 109);
            this.label_soft_amp.Name = "label_soft_amp";
            this.label_soft_amp.Size = new System.Drawing.Size(95, 19);
            this.label_soft_amp.TabIndex = 6;
            this.label_soft_amp.Text = "软件增益:";
            // 
            // label_time_coeff
            // 
            this.label_time_coeff.AutoSize = true;
            this.label_time_coeff.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time_coeff.Location = new System.Drawing.Point(9, 144);
            this.label_time_coeff.Name = "label_time_coeff";
            this.label_time_coeff.Size = new System.Drawing.Size(95, 19);
            this.label_time_coeff.TabIndex = 8;
            this.label_time_coeff.Text = "时间常数:";
            // 
            // label_form_time
            // 
            this.label_form_time.AutoSize = true;
            this.label_form_time.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_form_time.Location = new System.Drawing.Point(9, 179);
            this.label_form_time.Name = "label_form_time";
            this.label_form_time.Size = new System.Drawing.Size(95, 19);
            this.label_form_time.TabIndex = 10;
            this.label_form_time.Text = "成形时间:";
            // 
            // label_fast_channel_trig_thresh
            // 
            this.label_fast_channel_trig_thresh.AutoSize = true;
            this.label_fast_channel_trig_thresh.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fast_channel_trig_thresh.Location = new System.Drawing.Point(9, 215);
            this.label_fast_channel_trig_thresh.Name = "label_fast_channel_trig_thresh";
            this.label_fast_channel_trig_thresh.Size = new System.Drawing.Size(152, 19);
            this.label_fast_channel_trig_thresh.TabIndex = 12;
            this.label_fast_channel_trig_thresh.Text = "快通道触发阈值:";
            // 
            // label_spectrum_channel_num
            // 
            this.label_spectrum_channel_num.AutoSize = true;
            this.label_spectrum_channel_num.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_spectrum_channel_num.Location = new System.Drawing.Point(9, 249);
            this.label_spectrum_channel_num.Name = "label_spectrum_channel_num";
            this.label_spectrum_channel_num.Size = new System.Drawing.Size(95, 19);
            this.label_spectrum_channel_num.TabIndex = 14;
            this.label_spectrum_channel_num.Text = "谱线道数:";
            // 
            // cb_trans_mode
            // 
            this.cb_trans_mode.FormattingEnabled = true;
            this.cb_trans_mode.Items.AddRange(new object[] {
            "传输谱线",
            "传输成形后的信号波形",
            "传输原始指数信号",
            "粒子模式",
            "α、β测量模式"});
            this.cb_trans_mode.Location = new System.Drawing.Point(129, 38);
            this.cb_trans_mode.Name = "cb_trans_mode";
            this.cb_trans_mode.Size = new System.Drawing.Size(191, 23);
            this.cb_trans_mode.TabIndex = 15;
            this.cb_trans_mode.SelectedIndexChanged += new System.EventHandler(this.cb_trans_mode_SelectedIndexChanged);
            // 
            // cb_hard_amp
            // 
            this.cb_hard_amp.FormattingEnabled = true;
            this.cb_hard_amp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_hard_amp.Location = new System.Drawing.Point(129, 73);
            this.cb_hard_amp.Name = "cb_hard_amp";
            this.cb_hard_amp.Size = new System.Drawing.Size(191, 23);
            this.cb_hard_amp.TabIndex = 16;
            this.cb_hard_amp.SelectedIndexChanged += new System.EventHandler(this.cb_hard_amp_SelectedIndexChanged);
            // 
            // cb_form_time
            // 
            this.cb_form_time.FormattingEnabled = true;
            this.cb_form_time.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36"});
            this.cb_form_time.Location = new System.Drawing.Point(129, 178);
            this.cb_form_time.Name = "cb_form_time";
            this.cb_form_time.Size = new System.Drawing.Size(155, 23);
            this.cb_form_time.TabIndex = 19;
            this.cb_form_time.SelectedValueChanged += new System.EventHandler(this.cb_form_time_SelectedValueChanged);
            this.cb_form_time.TextChanged += new System.EventHandler(this.tb_fast_channel_trig_thresh_TextChanged);
            // 
            // tb_time_coeff
            // 
            this.tb_time_coeff.Location = new System.Drawing.Point(129, 143);
            this.tb_time_coeff.Name = "tb_time_coeff";
            this.tb_time_coeff.Size = new System.Drawing.Size(155, 25);
            this.tb_time_coeff.TabIndex = 20;
            this.tb_time_coeff.TextChanged += new System.EventHandler(this.tb_time_coeff_TextChanged);
            // 
            // tb_soft_amp
            // 
            this.tb_soft_amp.Location = new System.Drawing.Point(129, 108);
            this.tb_soft_amp.Name = "tb_soft_amp";
            this.tb_soft_amp.Size = new System.Drawing.Size(191, 25);
            this.tb_soft_amp.TabIndex = 21;
            this.tb_soft_amp.TextChanged += new System.EventHandler(this.tb_soft_amp_TextChanged);
            // 
            // cb_spectrum_channel_num
            // 
            this.cb_spectrum_channel_num.FormattingEnabled = true;
            this.cb_spectrum_channel_num.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "65536"});
            this.cb_spectrum_channel_num.Location = new System.Drawing.Point(129, 248);
            this.cb_spectrum_channel_num.Name = "cb_spectrum_channel_num";
            this.cb_spectrum_channel_num.Size = new System.Drawing.Size(191, 23);
            this.cb_spectrum_channel_num.TabIndex = 23;
            this.cb_spectrum_channel_num.SelectedIndexChanged += new System.EventHandler(this.cb_spectrum_channel_num_SelectedIndexChanged);
            // 
            // label_form_time_unit
            // 
            this.label_form_time_unit.AutoSize = true;
            this.label_form_time_unit.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_form_time_unit.Location = new System.Drawing.Point(291, 214);
            this.label_form_time_unit.Name = "label_form_time_unit";
            this.label_form_time_unit.Size = new System.Drawing.Size(29, 19);
            this.label_form_time_unit.TabIndex = 24;
            this.label_form_time_unit.Text = "mV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(291, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "us";
            // 
            // label_time_coeff_unit
            // 
            this.label_time_coeff_unit.AutoSize = true;
            this.label_time_coeff_unit.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time_coeff_unit.Location = new System.Drawing.Point(291, 145);
            this.label_time_coeff_unit.Name = "label_time_coeff_unit";
            this.label_time_coeff_unit.Size = new System.Drawing.Size(29, 19);
            this.label_time_coeff_unit.TabIndex = 26;
            this.label_time_coeff_unit.Text = "us";
            // 
            // label_multi_cast_endpoint
            // 
            this.label_multi_cast_endpoint.AutoSize = true;
            this.label_multi_cast_endpoint.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_multi_cast_endpoint.Location = new System.Drawing.Point(10, 47);
            this.label_multi_cast_endpoint.Name = "label_multi_cast_endpoint";
            this.label_multi_cast_endpoint.Size = new System.Drawing.Size(95, 19);
            this.label_multi_cast_endpoint.TabIndex = 27;
            this.label_multi_cast_endpoint.Text = "组播地址:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(10, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "238.228.218.208:12321";
            // 
            // bt_device_config
            // 
            this.bt_device_config.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_device_config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_device_config.Location = new System.Drawing.Point(12, 275);
            this.bt_device_config.Name = "bt_device_config";
            this.bt_device_config.Size = new System.Drawing.Size(308, 27);
            this.bt_device_config.TabIndex = 29;
            this.bt_device_config.Text = "设置";
            this.bt_device_config.UseVisualStyleBackColor = true;
            this.bt_device_config.Click += new System.EventHandler(this.bt_device_config_Click);
            // 
            // tb_direct_shift
            // 
            this.tb_direct_shift.Location = new System.Drawing.Point(129, 314);
            this.tb_direct_shift.Name = "tb_direct_shift";
            this.tb_direct_shift.Size = new System.Drawing.Size(156, 25);
            this.tb_direct_shift.TabIndex = 31;
            this.tb_direct_shift.TextChanged += new System.EventHandler(this.tb_direct_shift_TextChanged);
            // 
            // label_direct_shift
            // 
            this.label_direct_shift.AutoSize = true;
            this.label_direct_shift.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_direct_shift.Location = new System.Drawing.Point(8, 315);
            this.label_direct_shift.Name = "label_direct_shift";
            this.label_direct_shift.Size = new System.Drawing.Size(95, 19);
            this.label_direct_shift.TabIndex = 30;
            this.label_direct_shift.Text = "直流偏置:";
            // 
            // label_direct_shift_unit
            // 
            this.label_direct_shift_unit.AutoSize = true;
            this.label_direct_shift_unit.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_direct_shift_unit.Location = new System.Drawing.Point(291, 315);
            this.label_direct_shift_unit.Name = "label_direct_shift_unit";
            this.label_direct_shift_unit.Size = new System.Drawing.Size(29, 19);
            this.label_direct_shift_unit.TabIndex = 32;
            this.label_direct_shift_unit.Text = "mV";
            // 
            // label_input_decay
            // 
            this.label_input_decay.AutoSize = true;
            this.label_input_decay.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_input_decay.Location = new System.Drawing.Point(6, 12);
            this.label_input_decay.Name = "label_input_decay";
            this.label_input_decay.Size = new System.Drawing.Size(95, 19);
            this.label_input_decay.TabIndex = 33;
            this.label_input_decay.Text = "输入衰减:";
            // 
            // label_CR_derivate
            // 
            this.label_CR_derivate.AutoSize = true;
            this.label_CR_derivate.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CR_derivate.Location = new System.Drawing.Point(7, 14);
            this.label_CR_derivate.Name = "label_CR_derivate";
            this.label_CR_derivate.Size = new System.Drawing.Size(77, 19);
            this.label_CR_derivate.TabIndex = 34;
            this.label_CR_derivate.Text = "CR微分:";
            // 
            // label_input_polar
            // 
            this.label_input_polar.AutoSize = true;
            this.label_input_polar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_input_polar.Location = new System.Drawing.Point(6, 16);
            this.label_input_polar.Name = "label_input_polar";
            this.label_input_polar.Size = new System.Drawing.Size(95, 19);
            this.label_input_polar.TabIndex = 35;
            this.label_input_polar.Text = "输入极性:";
            // 
            // rb_input_decay_on
            // 
            this.rb_input_decay_on.AutoSize = true;
            this.rb_input_decay_on.Location = new System.Drawing.Point(120, 13);
            this.rb_input_decay_on.Name = "rb_input_decay_on";
            this.rb_input_decay_on.Size = new System.Drawing.Size(58, 19);
            this.rb_input_decay_on.TabIndex = 36;
            this.rb_input_decay_on.Text = "开启";
            this.rb_input_decay_on.UseVisualStyleBackColor = true;
            this.rb_input_decay_on.CheckedChanged += new System.EventHandler(this.rb_input_decay_on_CheckedChanged);
            // 
            // rb_input_decay_off
            // 
            this.rb_input_decay_off.AutoSize = true;
            this.rb_input_decay_off.Checked = true;
            this.rb_input_decay_off.Location = new System.Drawing.Point(205, 13);
            this.rb_input_decay_off.Name = "rb_input_decay_off";
            this.rb_input_decay_off.Size = new System.Drawing.Size(58, 19);
            this.rb_input_decay_off.TabIndex = 37;
            this.rb_input_decay_off.TabStop = true;
            this.rb_input_decay_off.Text = "关闭";
            this.rb_input_decay_off.UseVisualStyleBackColor = true;
            // 
            // rb_CR_deriv_off
            // 
            this.rb_CR_deriv_off.AutoSize = true;
            this.rb_CR_deriv_off.Checked = true;
            this.rb_CR_deriv_off.Location = new System.Drawing.Point(203, 14);
            this.rb_CR_deriv_off.Name = "rb_CR_deriv_off";
            this.rb_CR_deriv_off.Size = new System.Drawing.Size(58, 19);
            this.rb_CR_deriv_off.TabIndex = 39;
            this.rb_CR_deriv_off.TabStop = true;
            this.rb_CR_deriv_off.Text = "关闭";
            this.rb_CR_deriv_off.UseVisualStyleBackColor = true;
            // 
            // rb_CR_deriv_on
            // 
            this.rb_CR_deriv_on.AutoSize = true;
            this.rb_CR_deriv_on.Location = new System.Drawing.Point(120, 14);
            this.rb_CR_deriv_on.Name = "rb_CR_deriv_on";
            this.rb_CR_deriv_on.Size = new System.Drawing.Size(58, 19);
            this.rb_CR_deriv_on.TabIndex = 38;
            this.rb_CR_deriv_on.Text = "开启";
            this.rb_CR_deriv_on.UseVisualStyleBackColor = true;
            this.rb_CR_deriv_on.CheckedChanged += new System.EventHandler(this.rb_CR_deriv_on_CheckedChanged);
            // 
            // rb_input_polar_negative
            // 
            this.rb_input_polar_negative.AutoSize = true;
            this.rb_input_polar_negative.Checked = true;
            this.rb_input_polar_negative.Location = new System.Drawing.Point(199, 16);
            this.rb_input_polar_negative.Name = "rb_input_polar_negative";
            this.rb_input_polar_negative.Size = new System.Drawing.Size(58, 19);
            this.rb_input_polar_negative.TabIndex = 41;
            this.rb_input_polar_negative.TabStop = true;
            this.rb_input_polar_negative.Text = "关闭";
            this.rb_input_polar_negative.UseVisualStyleBackColor = true;
            // 
            // rb_input_polar_positive
            // 
            this.rb_input_polar_positive.AutoSize = true;
            this.rb_input_polar_positive.Location = new System.Drawing.Point(115, 17);
            this.rb_input_polar_positive.Name = "rb_input_polar_positive";
            this.rb_input_polar_positive.Size = new System.Drawing.Size(58, 19);
            this.rb_input_polar_positive.TabIndex = 40;
            this.rb_input_polar_positive.Text = "开启";
            this.rb_input_polar_positive.UseVisualStyleBackColor = true;
            this.rb_input_polar_positive.CheckedChanged += new System.EventHandler(this.rb_input_polar_positive_CheckedChanged);
            // 
            // bt_input_feature_config
            // 
            this.bt_input_feature_config.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_input_feature_config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_input_feature_config.Location = new System.Drawing.Point(13, 467);
            this.bt_input_feature_config.Name = "bt_input_feature_config";
            this.bt_input_feature_config.Size = new System.Drawing.Size(307, 27);
            this.bt_input_feature_config.TabIndex = 42;
            this.bt_input_feature_config.Text = "设置";
            this.bt_input_feature_config.UseVisualStyleBackColor = true;
            this.bt_input_feature_config.Click += new System.EventHandler(this.bt_input_feature_config_Click);
            // 
            // label_energy_range_unit
            // 
            this.label_energy_range_unit.AutoSize = true;
            this.label_energy_range_unit.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_energy_range_unit.Location = new System.Drawing.Point(225, 505);
            this.label_energy_range_unit.Name = "label_energy_range_unit";
            this.label_energy_range_unit.Size = new System.Drawing.Size(39, 19);
            this.label_energy_range_unit.TabIndex = 45;
            this.label_energy_range_unit.Text = "KeV";
            // 
            // tb_energy_range
            // 
            this.tb_energy_range.Location = new System.Drawing.Point(149, 504);
            this.tb_energy_range.Name = "tb_energy_range";
            this.tb_energy_range.Size = new System.Drawing.Size(81, 25);
            this.tb_energy_range.TabIndex = 44;
            this.tb_energy_range.TextChanged += new System.EventHandler(this.tb_energy_range_TextChanged);
            // 
            // label_energy_range
            // 
            this.label_energy_range.AutoSize = true;
            this.label_energy_range.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_energy_range.Location = new System.Drawing.Point(10, 505);
            this.label_energy_range.Name = "label_energy_range";
            this.label_energy_range.Size = new System.Drawing.Size(95, 19);
            this.label_energy_range.TabIndex = 43;
            this.label_energy_range.Text = "能量范围:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(234, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "%";
            // 
            // tb_am_peak_area_ratio
            // 
            this.tb_am_peak_area_ratio.Location = new System.Drawing.Point(149, 537);
            this.tb_am_peak_area_ratio.Name = "tb_am_peak_area_ratio";
            this.tb_am_peak_area_ratio.Size = new System.Drawing.Size(81, 25);
            this.tb_am_peak_area_ratio.TabIndex = 47;
            // 
            // label_am_peak_area_ratio
            // 
            this.label_am_peak_area_ratio.AutoSize = true;
            this.label_am_peak_area_ratio.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_am_peak_area_ratio.Location = new System.Drawing.Point(9, 537);
            this.label_am_peak_area_ratio.Name = "label_am_peak_area_ratio";
            this.label_am_peak_area_ratio.Size = new System.Drawing.Size(134, 19);
            this.label_am_peak_area_ratio.TabIndex = 46;
            this.label_am_peak_area_ratio.Text = "Am峰面积比例:";
            // 
            // tb_peak_correct_coeff
            // 
            this.tb_peak_correct_coeff.Location = new System.Drawing.Point(149, 571);
            this.tb_peak_correct_coeff.Name = "tb_peak_correct_coeff";
            this.tb_peak_correct_coeff.Size = new System.Drawing.Size(111, 25);
            this.tb_peak_correct_coeff.TabIndex = 50;
            // 
            // label_peak_correct_coeff
            // 
            this.label_peak_correct_coeff.AutoSize = true;
            this.label_peak_correct_coeff.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_peak_correct_coeff.Location = new System.Drawing.Point(10, 572);
            this.label_peak_correct_coeff.Name = "label_peak_correct_coeff";
            this.label_peak_correct_coeff.Size = new System.Drawing.Size(133, 19);
            this.label_peak_correct_coeff.TabIndex = 49;
            this.label_peak_correct_coeff.Text = "峰位校正系数:";
            // 
            // bt_energy_range_config
            // 
            this.bt_energy_range_config.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_energy_range_config.Location = new System.Drawing.Point(267, 503);
            this.bt_energy_range_config.Name = "bt_energy_range_config";
            this.bt_energy_range_config.Size = new System.Drawing.Size(53, 23);
            this.bt_energy_range_config.TabIndex = 51;
            this.bt_energy_range_config.Text = "设置";
            this.bt_energy_range_config.UseVisualStyleBackColor = true;
            // 
            // bt_write_am_ratio
            // 
            this.bt_write_am_ratio.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_write_am_ratio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_write_am_ratio.Location = new System.Drawing.Point(267, 537);
            this.bt_write_am_ratio.Name = "bt_write_am_ratio";
            this.bt_write_am_ratio.Size = new System.Drawing.Size(53, 23);
            this.bt_write_am_ratio.TabIndex = 52;
            this.bt_write_am_ratio.Text = "写";
            this.bt_write_am_ratio.UseVisualStyleBackColor = true;
            // 
            // bt_read_pead_correct_coeff
            // 
            this.bt_read_pead_correct_coeff.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_read_pead_correct_coeff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_read_pead_correct_coeff.Location = new System.Drawing.Point(267, 571);
            this.bt_read_pead_correct_coeff.Name = "bt_read_pead_correct_coeff";
            this.bt_read_pead_correct_coeff.Size = new System.Drawing.Size(53, 23);
            this.bt_read_pead_correct_coeff.TabIndex = 53;
            this.bt_read_pead_correct_coeff.Text = "读";
            this.bt_read_pead_correct_coeff.UseVisualStyleBackColor = true;
            // 
            // tb_high_voltage
            // 
            this.tb_high_voltage.Location = new System.Drawing.Point(7, 38);
            this.tb_high_voltage.Name = "tb_high_voltage";
            this.tb_high_voltage.Size = new System.Drawing.Size(149, 25);
            this.tb_high_voltage.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(162, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "V";
            // 
            // bt_start_measure
            // 
            this.bt_start_measure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_start_measure.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_start_measure.ForeColor = System.Drawing.Color.Teal;
            this.bt_start_measure.Location = new System.Drawing.Point(9, 80);
            this.bt_start_measure.Name = "bt_start_measure";
            this.bt_start_measure.Size = new System.Drawing.Size(130, 27);
            this.bt_start_measure.TabIndex = 58;
            this.bt_start_measure.Text = "启动测量";
            this.bt_start_measure.UseVisualStyleBackColor = false;
            this.bt_start_measure.Click += new System.EventHandler(this.bt_start_measure_Click);
            // 
            // bt_extract_spectrum_data
            // 
            this.bt_extract_spectrum_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_extract_spectrum_data.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_extract_spectrum_data.ForeColor = System.Drawing.Color.Lime;
            this.bt_extract_spectrum_data.Location = new System.Drawing.Point(8, 122);
            this.bt_extract_spectrum_data.Name = "bt_extract_spectrum_data";
            this.bt_extract_spectrum_data.Size = new System.Drawing.Size(130, 27);
            this.bt_extract_spectrum_data.TabIndex = 59;
            this.bt_extract_spectrum_data.Text = "获取谱线";
            this.bt_extract_spectrum_data.UseVisualStyleBackColor = false;
            this.bt_extract_spectrum_data.Click += new System.EventHandler(this.bt_extract_spectrum_data_Click);
            // 
            // bt_high_voltage_config
            // 
            this.bt_high_voltage_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_high_voltage_config.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_high_voltage_config.ForeColor = System.Drawing.Color.Teal;
            this.bt_high_voltage_config.Location = new System.Drawing.Point(185, 35);
            this.bt_high_voltage_config.Name = "bt_high_voltage_config";
            this.bt_high_voltage_config.Size = new System.Drawing.Size(130, 27);
            this.bt_high_voltage_config.TabIndex = 60;
            this.bt_high_voltage_config.Text = "设置高压";
            this.bt_high_voltage_config.UseVisualStyleBackColor = false;
            this.bt_high_voltage_config.Click += new System.EventHandler(this.bt_high_voltage_config_Click);
            // 
            // bt_stop_measure
            // 
            this.bt_stop_measure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_stop_measure.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_stop_measure.ForeColor = System.Drawing.Color.Red;
            this.bt_stop_measure.Location = new System.Drawing.Point(185, 80);
            this.bt_stop_measure.Name = "bt_stop_measure";
            this.bt_stop_measure.Size = new System.Drawing.Size(130, 27);
            this.bt_stop_measure.TabIndex = 61;
            this.bt_stop_measure.Text = "停止测量";
            this.bt_stop_measure.UseVisualStyleBackColor = false;
            this.bt_stop_measure.Click += new System.EventHandler(this.bt_stop_measure_Click);
            // 
            // bt_clear_spectrum_data
            // 
            this.bt_clear_spectrum_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_clear_spectrum_data.Font = new System.Drawing.Font("KaiTi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_clear_spectrum_data.ForeColor = System.Drawing.Color.Brown;
            this.bt_clear_spectrum_data.Location = new System.Drawing.Point(185, 122);
            this.bt_clear_spectrum_data.Name = "bt_clear_spectrum_data";
            this.bt_clear_spectrum_data.Size = new System.Drawing.Size(130, 27);
            this.bt_clear_spectrum_data.TabIndex = 62;
            this.bt_clear_spectrum_data.Text = "清空谱线";
            this.bt_clear_spectrum_data.UseVisualStyleBackColor = false;
            // 
            // label_spec_refresh_interval
            // 
            this.label_spec_refresh_interval.AutoSize = true;
            this.label_spec_refresh_interval.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_spec_refresh_interval.ForeColor = System.Drawing.Color.Blue;
            this.label_spec_refresh_interval.Location = new System.Drawing.Point(5, 164);
            this.label_spec_refresh_interval.Name = "label_spec_refresh_interval";
            this.label_spec_refresh_interval.Size = new System.Drawing.Size(140, 19);
            this.label_spec_refresh_interval.TabIndex = 63;
            this.label_spec_refresh_interval.Text = "谱线刷新间隔:";
            // 
            // label_limit_measure_time
            // 
            this.label_limit_measure_time.AutoSize = true;
            this.label_limit_measure_time.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_limit_measure_time.ForeColor = System.Drawing.Color.Blue;
            this.label_limit_measure_time.Location = new System.Drawing.Point(7, 202);
            this.label_limit_measure_time.Name = "label_limit_measure_time";
            this.label_limit_measure_time.Size = new System.Drawing.Size(140, 19);
            this.label_limit_measure_time.TabIndex = 64;
            this.label_limit_measure_time.Text = "定时测量时间:";
            // 
            // label_total_measure_count
            // 
            this.label_total_measure_count.AutoSize = true;
            this.label_total_measure_count.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_total_measure_count.ForeColor = System.Drawing.Color.Blue;
            this.label_total_measure_count.Location = new System.Drawing.Point(7, 238);
            this.label_total_measure_count.Name = "label_total_measure_count";
            this.label_total_measure_count.Size = new System.Drawing.Size(140, 19);
            this.label_total_measure_count.TabIndex = 65;
            this.label_total_measure_count.Text = "总共测量次数:";
            // 
            // tb_total_measure_times
            // 
            this.tb_total_measure_times.Location = new System.Drawing.Point(152, 238);
            this.tb_total_measure_times.Name = "tb_total_measure_times";
            this.tb_total_measure_times.Size = new System.Drawing.Size(128, 25);
            this.tb_total_measure_times.TabIndex = 66;
            this.tb_total_measure_times.TextChanged += new System.EventHandler(this.tb_total_measure_times_TextChanged);
            // 
            // tb_measure_time_seconds
            // 
            this.tb_measure_time_seconds.Location = new System.Drawing.Point(152, 201);
            this.tb_measure_time_seconds.Name = "tb_measure_time_seconds";
            this.tb_measure_time_seconds.Size = new System.Drawing.Size(128, 25);
            this.tb_measure_time_seconds.TabIndex = 67;
            this.tb_measure_time_seconds.TextChanged += new System.EventHandler(this.tb_measure_time_seconds_TextChanged);
            // 
            // tb_spec_refresh_interval
            // 
            this.tb_spec_refresh_interval.Location = new System.Drawing.Point(151, 164);
            this.tb_spec_refresh_interval.Name = "tb_spec_refresh_interval";
            this.tb_spec_refresh_interval.Size = new System.Drawing.Size(130, 25);
            this.tb_spec_refresh_interval.TabIndex = 68;
            this.tb_spec_refresh_interval.TextChanged += new System.EventHandler(this.tb_spec_refresh_interval_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(287, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "次";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(286, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 70;
            this.label7.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(287, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 71;
            this.label8.Text = "秒";
            // 
            // gb_device_connect
            // 
            this.gb_device_connect.Controls.Add(this.bt_connect_device);
            this.gb_device_connect.Controls.Add(this.label_multi_cast_endpoint);
            this.gb_device_connect.Controls.Add(this.label12);
            this.gb_device_connect.Location = new System.Drawing.Point(1342, 12);
            this.gb_device_connect.Name = "gb_device_connect";
            this.gb_device_connect.Size = new System.Drawing.Size(333, 115);
            this.gb_device_connect.TabIndex = 72;
            this.gb_device_connect.TabStop = false;
            this.gb_device_connect.Text = "连接设备";
            // 
            // gb_param_config
            // 
            this.gb_param_config.Controls.Add(this.groupBox5);
            this.gb_param_config.Controls.Add(this.tb_fast_channel_trig_thresh);
            this.gb_param_config.Controls.Add(this.groupBox4);
            this.gb_param_config.Controls.Add(this.label_trans_mode);
            this.gb_param_config.Controls.Add(this.groupBox3);
            this.gb_param_config.Controls.Add(this.label_hard_amp);
            this.gb_param_config.Controls.Add(this.label_soft_amp);
            this.gb_param_config.Controls.Add(this.label_time_coeff);
            this.gb_param_config.Controls.Add(this.label_form_time);
            this.gb_param_config.Controls.Add(this.label_fast_channel_trig_thresh);
            this.gb_param_config.Controls.Add(this.label_spectrum_channel_num);
            this.gb_param_config.Controls.Add(this.cb_trans_mode);
            this.gb_param_config.Controls.Add(this.cb_hard_amp);
            this.gb_param_config.Controls.Add(this.cb_form_time);
            this.gb_param_config.Controls.Add(this.tb_time_coeff);
            this.gb_param_config.Controls.Add(this.tb_soft_amp);
            this.gb_param_config.Controls.Add(this.cb_spectrum_channel_num);
            this.gb_param_config.Controls.Add(this.label_form_time_unit);
            this.gb_param_config.Controls.Add(this.label9);
            this.gb_param_config.Controls.Add(this.label_time_coeff_unit);
            this.gb_param_config.Controls.Add(this.bt_device_config);
            this.gb_param_config.Controls.Add(this.bt_read_pead_correct_coeff);
            this.gb_param_config.Controls.Add(this.label_direct_shift);
            this.gb_param_config.Controls.Add(this.bt_write_am_ratio);
            this.gb_param_config.Controls.Add(this.tb_direct_shift);
            this.gb_param_config.Controls.Add(this.bt_energy_range_config);
            this.gb_param_config.Controls.Add(this.label_direct_shift_unit);
            this.gb_param_config.Controls.Add(this.tb_peak_correct_coeff);
            this.gb_param_config.Controls.Add(this.label_peak_correct_coeff);
            this.gb_param_config.Controls.Add(this.label1);
            this.gb_param_config.Controls.Add(this.tb_am_peak_area_ratio);
            this.gb_param_config.Controls.Add(this.label_am_peak_area_ratio);
            this.gb_param_config.Controls.Add(this.label_energy_range_unit);
            this.gb_param_config.Controls.Add(this.tb_energy_range);
            this.gb_param_config.Controls.Add(this.label_energy_range);
            this.gb_param_config.Controls.Add(this.bt_input_feature_config);
            this.gb_param_config.Enabled = false;
            this.gb_param_config.Location = new System.Drawing.Point(1342, 137);
            this.gb_param_config.Name = "gb_param_config";
            this.gb_param_config.Size = new System.Drawing.Size(333, 607);
            this.gb_param_config.TabIndex = 73;
            this.gb_param_config.TabStop = false;
            this.gb_param_config.Text = "参数设置";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_input_polar);
            this.groupBox5.Controls.Add(this.rb_input_polar_negative);
            this.groupBox5.Controls.Add(this.rb_input_polar_positive);
            this.groupBox5.Location = new System.Drawing.Point(19, 419);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 41);
            this.groupBox5.TabIndex = 82;
            this.groupBox5.TabStop = false;
            // 
            // tb_fast_channel_trig_thresh
            // 
            this.tb_fast_channel_trig_thresh.Location = new System.Drawing.Point(166, 215);
            this.tb_fast_channel_trig_thresh.Name = "tb_fast_channel_trig_thresh";
            this.tb_fast_channel_trig_thresh.Size = new System.Drawing.Size(119, 25);
            this.tb_fast_channel_trig_thresh.TabIndex = 54;
            this.tb_fast_channel_trig_thresh.TextChanged += new System.EventHandler(this.tb_fast_channel_trig_thresh_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_CR_derivate);
            this.groupBox4.Controls.Add(this.rb_CR_deriv_off);
            this.groupBox4.Controls.Add(this.rb_CR_deriv_on);
            this.groupBox4.Location = new System.Drawing.Point(14, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 41);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_input_decay);
            this.groupBox3.Controls.Add(this.rb_input_decay_off);
            this.groupBox3.Controls.Add(this.rb_input_decay_on);
            this.groupBox3.Location = new System.Drawing.Point(14, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 41);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // gb_device_operate
            // 
            this.gb_device_operate.Controls.Add(this.tb_high_voltage);
            this.gb_device_operate.Controls.Add(this.label2);
            this.gb_device_operate.Controls.Add(this.bt_start_measure);
            this.gb_device_operate.Controls.Add(this.label8);
            this.gb_device_operate.Controls.Add(this.bt_extract_spectrum_data);
            this.gb_device_operate.Controls.Add(this.label7);
            this.gb_device_operate.Controls.Add(this.bt_high_voltage_config);
            this.gb_device_operate.Controls.Add(this.label6);
            this.gb_device_operate.Controls.Add(this.bt_stop_measure);
            this.gb_device_operate.Controls.Add(this.tb_spec_refresh_interval);
            this.gb_device_operate.Controls.Add(this.bt_clear_spectrum_data);
            this.gb_device_operate.Controls.Add(this.tb_measure_time_seconds);
            this.gb_device_operate.Controls.Add(this.label_spec_refresh_interval);
            this.gb_device_operate.Controls.Add(this.tb_total_measure_times);
            this.gb_device_operate.Controls.Add(this.label_limit_measure_time);
            this.gb_device_operate.Controls.Add(this.label_total_measure_count);
            this.gb_device_operate.Enabled = false;
            this.gb_device_operate.Location = new System.Drawing.Point(1342, 750);
            this.gb_device_operate.Name = "gb_device_operate";
            this.gb_device_operate.Size = new System.Drawing.Size(330, 269);
            this.gb_device_operate.TabIndex = 74;
            this.gb_device_operate.TabStop = false;
            this.gb_device_operate.Text = "设备操作";
            // 
            // rtb_send_command
            // 
            this.rtb_send_command.Location = new System.Drawing.Point(6, 24);
            this.rtb_send_command.Name = "rtb_send_command";
            this.rtb_send_command.Size = new System.Drawing.Size(509, 186);
            this.rtb_send_command.TabIndex = 75;
            this.rtb_send_command.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_clear_send_command);
            this.groupBox1.Controls.Add(this.bt_send_command);
            this.groupBox1.Controls.Add(this.rtb_send_command);
            this.groupBox1.Location = new System.Drawing.Point(303, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 242);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送命令";
            // 
            // bt_clear_send_command
            // 
            this.bt_clear_send_command.Location = new System.Drawing.Point(535, 27);
            this.bt_clear_send_command.Name = "bt_clear_send_command";
            this.bt_clear_send_command.Size = new System.Drawing.Size(75, 43);
            this.bt_clear_send_command.TabIndex = 79;
            this.bt_clear_send_command.Text = "清空";
            this.bt_clear_send_command.UseVisualStyleBackColor = true;
            this.bt_clear_send_command.Click += new System.EventHandler(this.bt_clear_send_command_Click);
            // 
            // bt_send_command
            // 
            this.bt_send_command.Location = new System.Drawing.Point(535, 166);
            this.bt_send_command.Name = "bt_send_command";
            this.bt_send_command.Size = new System.Drawing.Size(75, 44);
            this.bt_send_command.TabIndex = 78;
            this.bt_send_command.Text = "发送";
            this.bt_send_command.UseVisualStyleBackColor = true;
            this.bt_send_command.Click += new System.EventHandler(this.bt_send_command_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_clear_received_message);
            this.groupBox2.Controls.Add(this.rtb_received_message);
            this.groupBox2.Location = new System.Drawing.Point(309, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 242);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收数据";
            // 
            // bt_clear_received_message
            // 
            this.bt_clear_received_message.Location = new System.Drawing.Point(529, 167);
            this.bt_clear_received_message.Name = "bt_clear_received_message";
            this.bt_clear_received_message.Size = new System.Drawing.Size(75, 43);
            this.bt_clear_received_message.TabIndex = 79;
            this.bt_clear_received_message.Text = "清空";
            this.bt_clear_received_message.UseVisualStyleBackColor = true;
            // 
            // rtb_received_message
            // 
            this.rtb_received_message.Location = new System.Drawing.Point(6, 24);
            this.rtb_received_message.Name = "rtb_received_message";
            this.rtb_received_message.ReadOnly = true;
            this.rtb_received_message.Size = new System.Drawing.Size(509, 186);
            this.rtb_received_message.TabIndex = 75;
            this.rtb_received_message.Text = "";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1027);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_device_operate);
            this.Controls.Add(this.gb_param_config);
            this.Controls.Add(this.gb_device_connect);
            this.Name = "form_main";
            this.Text = "DP3300";
            this.gb_device_connect.ResumeLayout(false);
            this.gb_device_connect.PerformLayout();
            this.gb_param_config.ResumeLayout(false);
            this.gb_param_config.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_device_operate.ResumeLayout(false);
            this.gb_device_operate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_connect_device;
        private System.Windows.Forms.Label label_trans_mode;
        private System.Windows.Forms.Label label_hard_amp;
        private System.Windows.Forms.Label label_soft_amp;
        private System.Windows.Forms.Label label_time_coeff;
        private System.Windows.Forms.Label label_form_time;
        private System.Windows.Forms.Label label_fast_channel_trig_thresh;
        private System.Windows.Forms.Label label_spectrum_channel_num;
        private System.Windows.Forms.ComboBox cb_trans_mode;
        private System.Windows.Forms.ComboBox cb_hard_amp;
        private System.Windows.Forms.ComboBox cb_form_time;
        private System.Windows.Forms.TextBox tb_time_coeff;
        private System.Windows.Forms.TextBox tb_soft_amp;
        private System.Windows.Forms.ComboBox cb_spectrum_channel_num;
        private System.Windows.Forms.Label label_form_time_unit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_time_coeff_unit;
        private System.Windows.Forms.Label label_multi_cast_endpoint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_device_config;
        private System.Windows.Forms.TextBox tb_direct_shift;
        private System.Windows.Forms.Label label_direct_shift;
        private System.Windows.Forms.Label label_direct_shift_unit;
        private System.Windows.Forms.Label label_input_decay;
        private System.Windows.Forms.Label label_CR_derivate;
        private System.Windows.Forms.Label label_input_polar;
        private System.Windows.Forms.RadioButton rb_input_decay_on;
        private System.Windows.Forms.RadioButton rb_input_decay_off;
        private System.Windows.Forms.RadioButton rb_CR_deriv_off;
        private System.Windows.Forms.RadioButton rb_CR_deriv_on;
        private System.Windows.Forms.RadioButton rb_input_polar_negative;
        private System.Windows.Forms.RadioButton rb_input_polar_positive;
        private System.Windows.Forms.Button bt_input_feature_config;
        private System.Windows.Forms.Label label_energy_range_unit;
        private System.Windows.Forms.TextBox tb_energy_range;
        private System.Windows.Forms.Label label_energy_range;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_am_peak_area_ratio;
        private System.Windows.Forms.Label label_am_peak_area_ratio;
        private System.Windows.Forms.TextBox tb_peak_correct_coeff;
        private System.Windows.Forms.Label label_peak_correct_coeff;
        private System.Windows.Forms.Button bt_energy_range_config;
        private System.Windows.Forms.Button bt_write_am_ratio;
        private System.Windows.Forms.Button bt_read_pead_correct_coeff;
        private System.Windows.Forms.TextBox tb_high_voltage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_start_measure;
        private System.Windows.Forms.Button bt_extract_spectrum_data;
        private System.Windows.Forms.Button bt_high_voltage_config;
        private System.Windows.Forms.Button bt_stop_measure;
        private System.Windows.Forms.Button bt_clear_spectrum_data;
        private System.Windows.Forms.Label label_spec_refresh_interval;
        private System.Windows.Forms.Label label_limit_measure_time;
        private System.Windows.Forms.Label label_total_measure_count;
        private System.Windows.Forms.TextBox tb_total_measure_times;
        private System.Windows.Forms.TextBox tb_measure_time_seconds;
        private System.Windows.Forms.TextBox tb_spec_refresh_interval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_device_connect;
        private System.Windows.Forms.GroupBox gb_param_config;
        private System.Windows.Forms.GroupBox gb_device_operate;
        private System.Windows.Forms.RichTextBox rtb_send_command;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_clear_send_command;
        private System.Windows.Forms.Button bt_send_command;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_clear_received_message;
        private System.Windows.Forms.RichTextBox rtb_received_message;
        private System.Windows.Forms.TextBox tb_fast_channel_trig_thresh;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

