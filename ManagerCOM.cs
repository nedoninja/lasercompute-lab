using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserComputeLab
{
    public partial class ManagerCOM : Form
    {
        public static bool isConnectedPort = false;
        private string portname = String.Empty;
        public ToolStripLabel connectedStatus;
        private string datareceived = String.Empty;
        public ManagerCOM()
        {
            InitializeComponent();
        }

        private void scanpotrs_Click(object sender, EventArgs e)
        {
            portselector.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0)
            {
                MessageBox.Show("Нет доступных COM-портов", "Ошибка подключения");
            }
            else portselector.Enabled = true;
            foreach (string portName in portnames)
            {       
                portselector.Items.Add(portName);
                if (portnames[0] != null)
                {
                    portselector.SelectedItem = portnames[0];
                }
            }
        }

        private void chooseport_Click(object sender, EventArgs e)
        {
            portname = portselector.GetItemText(portselector.SelectedItem);
            try
            {
                serialPort.PortName = portname;
                serialPort.Open();
                isConnectedPort = true;
                portdisconnect.Enabled = true;
                chooseport.Enabled = false;
                speedselector.Enabled = true;
                connectedStatus.Text = "Подключено " + portname;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Невозможно подключиться к порту " + portname + ", проверьте подключено ли устроство или закройте программы, которые его также используют.", "Ошибка доступа к порту");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Этого порта не существует (" + portname + "), проверьте подключение устройства.", "Ошибка доступа к порту");
            }
            catch(Exception)
            {
                MessageBox.Show("Не удалось подключиться к " + portname + " по неизвестной причине.", "Ошибка доступа к порту");
            }
        }

        private void portdisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            isConnectedPort = false;
            portdisconnect.Enabled = false;
            chooseport.Enabled = true;
        }

        private void speedselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = Convert.ToInt32(speedselector.SelectedText);
        }
        public SerialPort getPort()
        {
            return serialPort;
        }
        public string getPortname()
        {
            return portname;
        }
        public string getDataReceived()
        {
            return datareceived;
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            datareceived = serialPort.ReadExisting();
        }
    }
}
