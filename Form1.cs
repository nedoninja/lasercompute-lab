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
    public partial class Form1 : Form
    {
        private ManagerCOM mcom;
        private SerialPort sp;
        private static string databuffer = String.Empty;
        private static string databuffer_add = String.Empty;
        private int mode = 0;
        public Form1()
        {
            InitializeComponent();
            panelBase.Visible = true;
        }

        private void labindex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (labindex.SelectedIndex == 0) {
                panelBase.Visible = true;
                panel0.Visible = false;
            }
            else if (labindex.SelectedIndex == 1) {
                panel0.Visible = true;
            }
        }

        private void managerCOM_Click(object sender, EventArgs e)
        {
            mcom = new ManagerCOM();
            mcom.connectedStatus = connectedStatus;
            sp = mcom.getPort();
            sp.DataReceived += serialPort_DataReceived;
            mcom.Show();
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sp.IsOpen) sp.Open();
                sp.WriteLine("!");
                databuffer_add = String.Empty;
                mode = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Не получилось отправить данные на порт " + mcom.getPortname(), "Ошибка отправки данных");
            }
        }
        private async void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (mcom != null)
            {
                string data = mcom.getDataReceived();
                databuffer = data;
                Invoke(new Action(() => databuffer_add += databuffer));
                Invoke(new Action(() => debugInput.Text += databuffer));
                if (mode == 1)
                {
                    // Режим корректировки
                    if (databuffer_add.Contains("Autocompute [done]\r\n"))
                    {
                        // Начинаем парсить данные
                        string[] lines = databuffer_add.Split('\n');
                        string floor = lines[1].Split(' ')[1];
                        string roof = lines[2].Split(' ')[1];
                        Invoke(new Action(() => floor1.Text = floor));
                        Invoke(new Action(() => roof1.Text = roof));
                    }
                }
            }
        }
        private void clearDebug_Click(object sender, EventArgs e)
        {
            debugInput.Text = String.Empty;
        }

        private void debugToolStrip_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem.CheckState == CheckState.Checked)
                groupDebug.Visible = true;
            else if (menuItem.CheckState == CheckState.Unchecked)
                groupDebug.Visible = false;
        }
    }
}
