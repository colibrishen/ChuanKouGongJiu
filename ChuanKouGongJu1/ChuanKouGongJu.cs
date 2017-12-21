using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChuanKouGongJu1
{
    public partial class ChuanKouGongJu : Form
    {
        private readonly SerialPort _comDevice = new SerialPort();
        private readonly Thread _work;
        private readonly bool _bwork;
        private bool _start;
        private readonly Queue<string> _mMgsQueue;

        public ChuanKouGongJu()
        {
            _mMgsQueue = new Queue<string>();
            _bwork = false;
            _start = false;
            InitializeComponent();
            Init();
            _bwork = true;
            _work = new Thread(Work);
            _work.Start();
        }

        #region 初始化

        private void ComInfor()
        {
            List<ComBoxParam> lstComb = new List<ComBoxParam>();

            ComBoxParam combTemp = new ComBoxParam();
            for (int i = 1; i < 20; i++)
            {
                combTemp = new ComBoxParam();
                combTemp.Name = "COM" + i;
                combTemp.Value = i;
                lstComb.Add(combTemp);
            }
            CombPort.DataSource = lstComb;
            CombPort.ValueMember = "Value";
            CombPort.DisplayMember = "Name";

            int[] strTemp = { 9600, 19200, 38400, 43000, 56000, 57600, 115200 };
            lstComb = new List<ComBoxParam>();
            foreach (int i in strTemp)
            {
                combTemp = new ComBoxParam();
                combTemp.Name = i.ToString();
                combTemp.Value = i;
                lstComb.Add(combTemp);
            }
            CombBaudRate.DataSource = lstComb;
            CombBaudRate.ValueMember = "Value";
            CombBaudRate.DisplayMember = "Name";

            int[] strTemp1 = { 8, 7, 6, 5 };
            lstComb = new List<ComBoxParam>();
            foreach (int i in strTemp1)
            {
                combTemp = new ComBoxParam();
                combTemp.Name = i.ToString();
                combTemp.Value = i;
                lstComb.Add(combTemp);
            }
            CombDataBits.DataSource = lstComb;
            CombDataBits.ValueMember = "Value";
            CombDataBits.DisplayMember = "Name";

            double[] strTemp2 = { 1, 1.5, 2 };
            lstComb = new List<ComBoxParam>();
            foreach (double i in strTemp2)
            {
                combTemp = new ComBoxParam();
                combTemp.Name = i.ToString();
                combTemp.DValue = i;
                lstComb.Add(combTemp);
            }
            CombStopBits.DataSource = lstComb;
            CombStopBits.ValueMember = "DValue";
            CombStopBits.DisplayMember = "Name";

            lstComb = new List<ComBoxParam>();
            combTemp = new ComBoxParam();
            combTemp.Name = "None";
            combTemp.Value = 0;
            lstComb.Add(combTemp);

            CombParity.DataSource = lstComb;
            CombParity.ValueMember = "Value";
            CombParity.DisplayMember = "Name";

        }

        #endregion

        public void Init()
        {
            _comDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived); //绑定事件
            ComInfor();
            radioButton2.Checked = true;
        }

        private void Work()
        {
            string strContent = string.Empty;
            while (_bwork)
            {
                bool enable = false;
                if (_start)
                {
                    if (_mMgsQueue.Count > 0)
                    {
                        lock (_mMgsQueue)
                        {
                            try
                            {
                                var temp = _mMgsQueue.Dequeue();
                                if (temp.Substring(0, 1) == "[")
                                {
                                    strContent = temp;
                                }
                                else if (temp.Substring(temp.Length - 1, 1) == "]")
                                {
                                    strContent += temp;
                                    _start = false;
                                    enable = true;
                                }
                                else
                                {
                                    strContent += temp;
                                }
                            }
                            catch
                            {
                                // ignored
                            }
                        }
                    }
                }
                if (enable)
                {
                    strContent = strContent.TrimStart('[').TrimEnd(']');
                    AddContent(strContent);
                }
                Thread.Sleep(50);
            }
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            if (_comDevice.IsOpen == false)
            {
                ComBoxParam comBoxParam = (ComBoxParam) CombPort.SelectedItem;
                _comDevice.PortName = comBoxParam.Name;
                _comDevice.BaudRate = 115200;
                _comDevice.Parity = (Parity)0;
                _comDevice.DataBits = 8;
                _comDevice.StopBits = (StopBits)1;
                try
                {
                    _comDevice.Open();
                    TxtOpenCom.Text = "连接成功";
                    TxtOpenCom.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    _comDevice.Close();
                    TxtOpenCom.Text = "断开连接";
                    TxtOpenCom.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[_comDevice.BytesToRead];
            _comDevice.Read(ReDatas, 0, ReDatas.Length); //读取数据
            _start = true;
            this.AddData(ReDatas); //输出数据
        }

        private string strk = string.Empty;

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
//         public void AddData(byte[] data)
//         {
//             StringBuilder sb = new StringBuilder();
//             for (int i = 0; i < data.Length; i++)
//             {
//                 sb.AppendFormat("{0:x2}" + " ", data[i]);
//             }
//             lock (_mMgsQueue)
//             {
//                 _mMgsQueue.Enqueue(new UTF8Encoding().GetString(data));
//             }
// 
//         }

        public void AddData(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte t in data)
            {
                sb.AppendFormat("{0:x2}" + " ", t);
            }
            
            if (radioButton1.Checked)
            {
                AddContent(sb.ToString().ToUpper());
            }

            if (radioButton2.Checked)
            {
                AddContent(new ASCIIEncoding().GetString(data));
            }

            if (radioButton3.Checked)
            {
                AddContent(new UTF8Encoding().GetString(data));
            }

            if (radioButton4.Checked)
            {
                AddContent(new UnicodeEncoding().GetString(data));
            }
            
        }

        /// <summary>
        /// 输入到显示区域
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (TxtReceiveMsg.Text.Length > 0)
                {
                    TxtReceiveMsg.AppendText("\r\n");
                }
                TxtReceiveMsg.AppendText(content);
            }));
        }

        private void ButClearSend_Click(object sender, EventArgs e)
        {
            TxtSendMsg.Text = string.Empty;
        }

        private void ButClearReceive_Click(object sender, EventArgs e)
        {
            TxtReceiveMsg.Text = string.Empty;
        }

        //发送消息
        private void ButSendMsg_Click(object sender, EventArgs e)
        {
            if (_comDevice.IsOpen)
            {
                try
                {
                    _comDevice.Encoding = System.Text.Encoding.GetEncoding("GB2312");
                    _comDevice.Write(TxtSendMsg.Text);//发送数据
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("请先打开串口！");
            }
        }
    }
}
