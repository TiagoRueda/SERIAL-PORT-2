using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SerialPortTest
{
    public partial class Form1 : Form
    {
        #region Definitions
        public byte[] Buffer_receive = new byte[Size_buffer];
        public const byte Size_buffer = 18;
        int Count;
        SerialPort SerialPort1 = new SerialPort();
        FileStream SaveData = null;
        String SaveFile = null;
        #endregion

        public Form1()
        {
            CheckForExistingInstance();
            InitializeComponent();
        }

        #region Init
        private void CheckForExistingInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();

            var existingProcess = (from proc in Process.GetProcesses()
                                   where proc.Id != currentProcess.Id && proc.ProcessName == currentProcess.ProcessName
                                   select proc).FirstOrDefault();

            if (existingProcess != null)
            {
                MessageBox.Show("Já está em execução!");
                Environment.Exit(0);
            }
        }

        private void InitializeConf()
        {
            
            string[] PortName = SerialPort.GetPortNames();
            foreach (string s in PortName)
            {
                CBCom.Items.Add(s);
            }
            CBCom.SelectedIndex = 1;

            string[] BaudRate = { "4800", "9600", "19200", "38400", "57600", "115200" };
            foreach (string s in BaudRate)
            {
                CBBaudRate.Items.Add(s);
            }
            CBBaudRate.SelectedIndex = 0;

            string[] DataBit = { "5", "6", "7", "8" };
            foreach (string s in DataBit)
            {
                CBDataBit.Items.Add(s);
            }
            CBDataBit.SelectedIndex = 3;

            string[] CheckBit = { "None", "Even", "Odd", "Mask", "Space" };
            foreach (string s in CheckBit)
            {
                CBCheckBit.Items.Add(s);
            }
            CBCheckBit.SelectedIndex = 0;

            string[] StopBit = { "1", "1.5", "2" };
            foreach (string s in StopBit)
            {
                CBStopBit.Items.Add(s);
            }
            CBStopBit.SelectedIndex = 0;

            RBTxDataASCII.Checked = true;
            RBRxDataASCII.Checked = true;

            Control.CheckForIllegalCrossThreadCalls = false;
            SerialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRx);
            SerialPort1.ReadBufferSize = 4096;
            SerialPort1.WriteBufferSize = 2048;
            SerialPort1.ReadTimeout = -1;
            SerialPort1.WriteTimeout = -1;
            SerialPort1.Handshake = Handshake.None;
        }

        private void Form1Init(object sender, EventArgs e)
        {
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeConf();

            BtSend.Enabled = false;
            TimerPort.Enabled = true;
        }

        private void UpdateAvailablePorts()
        {
            string[] availablePorts = SerialPort.GetPortNames();

            if (CBCom.Items.Count != availablePorts.Length || !CBCom.Items.Cast<string>().SequenceEqual(availablePorts))
            {
                CBCom.Items.Clear();
                CBCom.Items.AddRange(availablePorts);
                CBCom.SelectedIndex = 0;
                CBBaudRate.SelectedIndex = 0;
                CBDataBit.SelectedIndex = 3;
                CBCheckBit.SelectedIndex = 0;
                CBStopBit.SelectedIndex = 0;
            }
        }

        private void TimerPort_Tick(object sender, EventArgs e)
        {
            UpdateAvailablePorts();
        }
        #endregion

        #region Buttons
        private void BtCom_Click(object sender, EventArgs e)
        {
            if (!SerialPort1.IsOpen)
            {
                try
                {   
                    if (CBCom.SelectedIndex == -1)
                    {
                        MessageBox.Show("Porta inválida");
                        return;
                    }
                    string strSerialName = CBCom.SelectedItem.ToString();
                    string strBaudRate = CBBaudRate.SelectedItem.ToString();
                    string strDataBit = CBDataBit.SelectedItem.ToString();
                    string strCheckBit = CBCheckBit.SelectedItem.ToString();
                    string strStopBit = CBStopBit.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDataBit  = Convert.ToInt32(strDataBit);

                    SerialPort1.PortName = strSerialName;
                    SerialPort1.BaudRate = iBaudRate;
                    SerialPort1.DataBits = iDataBit;

                    switch (strStopBit)            
                    {
                        case "1":
                            SerialPort1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            SerialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            SerialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            break;
                    }
                    switch (strCheckBit) 
                    {
                        case "None":
                            SerialPort1.Parity = Parity.None;
                            break;
                        case "Odd":
                            SerialPort1.Parity = Parity.Odd;
                            break;
                        case "Even":
                            SerialPort1.Parity = Parity.Even;
                            break;
                        default:
                            break;
                    }

                    if (SaveFile != null)
                    {
                        SaveData = File.Create(SaveFile);
                    }

                    SerialPort1.Open();
                    CBCom.Enabled = false;
                    CBBaudRate.Enabled = false;
                    CBDataBit.Enabled = false;
                    CBCheckBit.Enabled = false;
                    CBStopBit.Enabled = false;
                    RBTxDataASCII.Enabled = false;
                    RBTxDataHex.Enabled = false;
                    RBRxDataASCII.Enabled = false;
                    RBRxDataHEX.Enabled = false;
                    BtSend.Enabled = true;
                    BtCom.Text = "Desconectar";
                }
                catch (Exception ex)
                {
                }
            }
            else 
            {
                SerialPort1.Close();
                CBCom.Enabled = true;
                CBBaudRate.Enabled = true;
                CBDataBit.Enabled = true;
                CBCheckBit.Enabled = true;
                CBStopBit.Enabled = true;
                RBTxDataASCII.Enabled = true;
                RBTxDataHex.Enabled = true;
                RBRxDataASCII.Enabled = true;
                RBRxDataHEX.Enabled = true;
                BtSend.Enabled = false;
                BtCom.Text = "Conectar";

                if (SaveData != null)
                {
                    SaveData.Close(); 
                    SaveData = null;
                }

            }
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TxtBoxReceive.Text = "";
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            String strSend = TxtBoxSend.Text;
            if (RBTxDataASCII.Checked == true)
            {
                SerialPort1.WriteLine(strSend);
            }
            else
            {
                string[] hexValues = strSend.Split(' ');

                byte[] data = new byte[hexValues.Length];

                for (int i = 0; i < hexValues.Length; i++)
                {
                    data[i] = Convert.ToByte(hexValues[i], 16);
                }
                try
                {
                    SerialPort1.Write(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void SaveDataRec_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "txt |*.txt";
            SaveFileDialog.Title = "Salvar o que foi recebido";
            SaveFileDialog.ShowDialog();

            if (SaveFileDialog.FileName != null)
            {
                SaveFile = SaveFileDialog.FileName;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close();
            }
            if (SaveData != null)
            {
                SaveData.Close();
                SaveData = null;
            }

            this.Close();
        }

        private void ResetConf_Click(object sender, EventArgs e)
        {
            CBCom.SelectedIndex = 0;
            CBBaudRate.SelectedIndex = 0;
            CBDataBit.SelectedIndex = 3;
            CBCheckBit.SelectedIndex = 0;
            CBStopBit.SelectedIndex = 0;
            RBTxDataASCII.Checked = true;
            RBRxDataASCII.Checked = true;
        }
        #endregion

        #region ReceiveData
        private void DataRx(object sender, SerialDataReceivedEventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                DateTime dateTimeNow = DateTime.Now;
                TxtBoxReceive.Text += string.Format("{0}\r\n", dateTimeNow);
                TxtBoxReceive.Text += "Received: ";
                TxtBoxReceive.ForeColor = Color.Black;

                try
                {
                    if (RBRxDataASCII.Checked)
                    {
                        int bytesToRead = SerialPort1.BytesToRead;
                        byte[] buffer = new byte[bytesToRead];
                        SerialPort1.Read(buffer, 0, bytesToRead);

                        string receivedData = Encoding.UTF8.GetString(buffer);
                        TxtBoxReceive.Text += receivedData + "\r\n";
                        Debug.WriteLine("ReceivedData: " + receivedData);

                        if (SaveData != null)
                        {
                            byte[] info = buffer;
                            SaveData.Write(info, 0, info.Length);
                        }
                    }
                    else
                    {
                        while (SerialPort1.BytesToRead > 0)
                        {
                            int bytesToRead = SerialPort1.ReadByte();
                            Buffer_receive[Count++] = (byte)bytesToRead;
                        }
                        Count = 0;
                        string hexString = "";
                        foreach (byte b in Buffer_receive)
                        {
                            hexString += $"{b:X2} ";
                        }
                        TxtBoxReceive.Text += hexString + "\r\n";
                        Debug.WriteLine("Received hexString: " + hexString);

                        if (SaveData != null)
                        {
                            hexString = hexString + "\r\n";
                            SaveData.Write(Encoding.ASCII.GetBytes(hexString), 0, hexString.Length);
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                TxtBoxReceive.SelectionStart = TxtBoxReceive.Text.Length;
                TxtBoxReceive.ScrollToCaret();
                SerialPort1.DiscardInBuffer();
            }
        }
        #endregion
    }
}
