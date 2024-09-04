using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            if (ports.Length != 0)
            {
                comboBox2.Items.AddRange(ports);
                comboBox2.SelectedIndex = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "connect") {
                try
                {
                    serialPort1.PortName = comboBox2.Text;
                    serialPort1.Open();
                    comboBox2.Enabled = false;
                    button5.Text = "disconnect";

                    
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }else if (button5.Text == "disconnect")
            {
                serialPort1.Close();
                comboBox2.Enabled=true;
                button5.Text = "connect";

               
            }
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           timer1.Start();
            

        }

        private void button1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            
        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string distance = serialPort1.ReadLine();
            label1.Text = "Distance is : " + distance;
            chart1.Series[0].Points.AddY(distance);
        }
    }
}
