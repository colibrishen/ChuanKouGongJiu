using System.Windows.Forms;

namespace ChuanKouGongJu1
{
    partial class ChuanKouGongJu
    { /// <summary>
      /// 必需的设计器变量。
      /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TxtReceiveMsg = new System.Windows.Forms.TextBox();
            this.ButStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CombParity = new System.Windows.Forms.ComboBox();
            this.CombStopBits = new System.Windows.Forms.ComboBox();
            this.CombDataBits = new System.Windows.Forms.ComboBox();
            this.CombBaudRate = new System.Windows.Forms.ComboBox();
            this.CombPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ButSendMsg = new System.Windows.Forms.Button();
            this.TxtSendMsg = new System.Windows.Forms.TextBox();
            this.ButClearSend = new System.Windows.Forms.Button();
            this.ButClearReceive = new System.Windows.Forms.Button();
            this.TxtOpenCom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtReceiveMsg
            // 
            this.TxtReceiveMsg.Location = new System.Drawing.Point(6, 20);
            this.TxtReceiveMsg.Multiline = true;
            this.TxtReceiveMsg.Name = "TxtReceiveMsg";
            this.TxtReceiveMsg.Size = new System.Drawing.Size(375, 311);
            this.TxtReceiveMsg.TabIndex = 1;
            // 
            // ButStart
            // 
            this.ButStart.Location = new System.Drawing.Point(118, 201);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(75, 23);
            this.ButStart.TabIndex = 2;
            this.ButStart.Text = "打开串口";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CombParity);
            this.groupBox1.Controls.Add(this.CombStopBits);
            this.groupBox1.Controls.Add(this.CombDataBits);
            this.groupBox1.Controls.Add(this.CombBaudRate);
            this.groupBox1.Controls.Add(this.CombPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口设置";
            // 
            // CombParity
            // 
            this.CombParity.FormattingEnabled = true;
            this.CombParity.Location = new System.Drawing.Point(60, 132);
            this.CombParity.Name = "CombParity";
            this.CombParity.Size = new System.Drawing.Size(121, 20);
            this.CombParity.TabIndex = 9;
            // 
            // CombStopBits
            // 
            this.CombStopBits.FormattingEnabled = true;
            this.CombStopBits.Location = new System.Drawing.Point(60, 104);
            this.CombStopBits.Name = "CombStopBits";
            this.CombStopBits.Size = new System.Drawing.Size(121, 20);
            this.CombStopBits.TabIndex = 8;
            // 
            // CombDataBits
            // 
            this.CombDataBits.FormattingEnabled = true;
            this.CombDataBits.Location = new System.Drawing.Point(60, 76);
            this.CombDataBits.Name = "CombDataBits";
            this.CombDataBits.Size = new System.Drawing.Size(121, 20);
            this.CombDataBits.TabIndex = 7;
            // 
            // CombBaudRate
            // 
            this.CombBaudRate.FormattingEnabled = true;
            this.CombBaudRate.Location = new System.Drawing.Point(60, 48);
            this.CombBaudRate.Name = "CombBaudRate";
            this.CombBaudRate.Size = new System.Drawing.Size(121, 20);
            this.CombBaudRate.TabIndex = 6;
            // 
            // CombPort
            // 
            this.CombPort.FormattingEnabled = true;
            this.CombPort.Location = new System.Drawing.Point(60, 20);
            this.CombPort.Name = "CombPort";
            this.CombPort.Size = new System.Drawing.Size(121, 20);
            this.CombPort.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "波特率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收编码";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 87);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Unicode";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "UTF-8";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtReceiveMsg);
            this.groupBox4.Location = new System.Drawing.Point(227, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 337);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收消息";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ButSendMsg);
            this.groupBox5.Controls.Add(this.TxtSendMsg);
            this.groupBox5.Location = new System.Drawing.Point(227, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 115);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送消息";
            // 
            // ButSendMsg
            // 
            this.ButSendMsg.Location = new System.Drawing.Point(300, 83);
            this.ButSendMsg.Name = "ButSendMsg";
            this.ButSendMsg.Size = new System.Drawing.Size(75, 23);
            this.ButSendMsg.TabIndex = 8;
            this.ButSendMsg.Text = "发送";
            this.ButSendMsg.UseVisualStyleBackColor = true;
            this.ButSendMsg.Click += new System.EventHandler(this.ButSendMsg_Click);
            // 
            // TxtSendMsg
            // 
            this.TxtSendMsg.Location = new System.Drawing.Point(6, 20);
            this.TxtSendMsg.Multiline = true;
            this.TxtSendMsg.Name = "TxtSendMsg";
            this.TxtSendMsg.Size = new System.Drawing.Size(369, 57);
            this.TxtSendMsg.TabIndex = 2;
            // 
            // ButClearSend
            // 
            this.ButClearSend.Location = new System.Drawing.Point(12, 421);
            this.ButClearSend.Name = "ButClearSend";
            this.ButClearSend.Size = new System.Drawing.Size(101, 23);
            this.ButClearSend.TabIndex = 9;
            this.ButClearSend.Text = "清空发送消息";
            this.ButClearSend.UseVisualStyleBackColor = true;
            this.ButClearSend.Click += new System.EventHandler(this.ButClearSend_Click);
            // 
            // ButClearReceive
            // 
            this.ButClearReceive.Location = new System.Drawing.Point(12, 392);
            this.ButClearReceive.Name = "ButClearReceive";
            this.ButClearReceive.Size = new System.Drawing.Size(101, 23);
            this.ButClearReceive.TabIndex = 10;
            this.ButClearReceive.Text = "清空接收消息";
            this.ButClearReceive.UseVisualStyleBackColor = true;
            this.ButClearReceive.Click += new System.EventHandler(this.ButClearReceive_Click);
            // 
            // TxtOpenCom
            // 
            this.TxtOpenCom.AutoSize = true;
            this.TxtOpenCom.Location = new System.Drawing.Point(20, 206);
            this.TxtOpenCom.Name = "TxtOpenCom";
            this.TxtOpenCom.Size = new System.Drawing.Size(41, 12);
            this.TxtOpenCom.TabIndex = 11;
            this.TxtOpenCom.Text = "未连接";
            // 
            // ChuanKouGongJu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 514);
            this.Controls.Add(this.TxtOpenCom);
            this.Controls.Add(this.ButClearReceive);
            this.Controls.Add(this.ButClearSend);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButStart);
            this.Name = "ChuanKouGongJu";
            this.Text = "串口调试工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtReceiveMsg;
        private System.Windows.Forms.Button ButStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CombPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CombParity;
        private System.Windows.Forms.ComboBox CombStopBits;
        private System.Windows.Forms.ComboBox CombDataBits;
        private System.Windows.Forms.ComboBox CombBaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ButSendMsg;
        private System.Windows.Forms.TextBox TxtSendMsg;
        private System.Windows.Forms.Button ButClearSend;
        private System.Windows.Forms.Button ButClearReceive;
        private System.Windows.Forms.Label TxtOpenCom;
    }
}

