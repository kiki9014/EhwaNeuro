using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Ehwaneuro01
{
    public partial class Form1 : Form
    {
        SerialPort serialP;
        Thread rsThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Conn_But_Click(object sender, EventArgs e)
        {
            if (serialP == null)
            {
                serialP = new SerialPort();
                serialP.PortName = PortNames.SelectedItem.ToString();
                serialP.BaudRate = Convert.ToInt32(BaudRates.SelectedItem);

                serialP.Open();
                serialP.DataReceived += new SerialDataReceivedEventHandler(Data_Recieved);
            }
        }

        private void Discon_But_Click(object sender, EventArgs e)
        {
            if (serialP.IsOpen) serialP.Close();
        }

        private void Sendtxt_TextChanged(object sender, EventArgs e)
        {
            serialP.WriteLine(Sendtxt.SelectedText);
        }

        private void Data_Recieved(object sender, SerialDataReceivedEventArgs e)
        {
            Recievtxt.SelectedText = serialP.ReadLine();
        }
    }
}
