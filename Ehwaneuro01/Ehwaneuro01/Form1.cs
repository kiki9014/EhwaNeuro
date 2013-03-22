using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ehwaneuro01
{
    public partial class Form1 : Form
    {
        SerialPort serialP;

        public Form1()
        {
            InitializeComponent();
        }

        private void Conn_But_Click(object sender, EventArgs e)
        {
            if (!serialP.IsOpen)
            {
                serialP.PortName = PortNames.SelectedText;
                serialP.BaudRate = Convert.ToInt32(BaudRates.SelectedText);

                serialP.Open();
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
    }
}
