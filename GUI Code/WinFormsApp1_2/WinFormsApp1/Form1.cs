

using System;
using System.IO.Ports;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort port = null;
        String data_rx = "";
        bool flag_st = false;
        string st = "";

        public Form1()
        {
            InitializeComponent();
            refresh_com();
            label1.Text = "Disconnected";
            label1.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_com();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void refresh_com()
        {

            comboBox1.DataSource = SerialPort.GetPortNames();

        }
        private void connect()
        {

            port = new SerialPort(comboBox1.SelectedItem.ToString());
            port.DataReceived += new SerialDataReceivedEventHandler(data_rx_handerler);
            port.BaudRate = 2400;
            port.DataBits = 8;
            port.StopBits = StopBits.One;

            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                    label1.Text = "Connected";
                    label1.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            { }
        }

        private void disconnect()
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                    label1.Text = "Disconnected";
                    label1.ForeColor = Color.Red;
                }
            }
            catch (Exception ex) { }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            port.Write("1");
            data_rx = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void data_rx_handerler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string tmp = sp.ReadExisting();
            data_rx += tmp;

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (data_rx.EndsWith("i"))
            {
                textBox2.Clear();
                textBox2.Text = "                   A car wants to enter the garage ";

            }
            else if (data_rx.EndsWith("o"))
            {
                textBox2.Clear();
                textBox2.Text = "                   A car wants to leave the garage ";

            }
            if (data_rx.Contains('@'))
            {
                int startindex = data_rx.IndexOf('@');
                int endindex = data_rx.IndexOf('!');
                if (endindex > 0)
                {
                    st = data_rx.Substring(startindex + 1, endindex - startindex - 1);
                    textBox3.Text = st;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            port.Write("2");
            data_rx = "";
            textBox2.Text = "";
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            port.Write("3");
            data_rx = "";
            textBox2.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            port.Write("4");
            data_rx = "";
            textBox2.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}