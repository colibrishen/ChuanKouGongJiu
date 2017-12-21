using System;
using System.IO.Ports;
using System.Text;

namespace ChuanKouGongJu1
{
    public class ComDevice
    {
        private SerialPort _serialPort;
        private byte[] _reDatas;

        public ComDevice()
        {
            _serialPort = new SerialPort();
            _reDatas = new byte[] { };
        }

        public void Init()
        {
            _serialPort.DataReceived += Com_DataReceived; //绑定事件
        }

        /// <summary>
        /// 打开关闭Com
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="parity"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="reMsg"></param>
        public void OpenCom(string portName, int baudRate, int parity, int dataBits, int stopBits, out string reMsg)
        {
            reMsg = string.Empty;
            if (_serialPort.IsOpen == false)
            {
                _serialPort.PortName = portName;
                _serialPort.BaudRate = baudRate;
                _serialPort.Parity = (Parity)parity;
                _serialPort.DataBits = dataBits;
                _serialPort.StopBits = (StopBits)stopBits;
                try
                {
                    _serialPort.Open();
                }
                catch (Exception ex)
                {
                    reMsg = ex.Message;
                }
            }
            else
            {
                try
                {
                    _serialPort.Close();
                }
                catch (Exception ex)
                {
                    reMsg = ex.Message;
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
            byte[] reDatas = new byte[_serialPort.BytesToRead];
            _serialPort.Read(reDatas, 0, reDatas.Length); //读取数据
            _reDatas = reDatas; //输出数据
        }

        public string GetInfor()
        {
            if (_reDatas.Length > 0)
            {
                return new ASCIIEncoding().GetString(_reDatas);
            }
            return string.Empty;
        }
    }
}
