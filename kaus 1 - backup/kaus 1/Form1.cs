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
using ZedGraph;



namespace kaus_1
{

    public partial class Form1 : Form
    {
        string[] port1 = new string[10];
        SerialPort port;
        int count = 0, flag = 1, Leftspeed = 0, Rightspeed = 0, j = 0, temp, form = 0;
        byte ls = 0, rs = 0, kp = 0, kd = 0, ki = 0, tok = 0;
        int baudrate = 115200;
        public Form1()
        {
            InitializeComponent();
        }
        const int input = 200;
        byte[] datarec = new byte[input];
        byte[] data1 = new byte[input];
        double[] x = new double[input];
        double[] y = new double[input];
        int d;

        void set_graph()
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = datarec[i];
            }
            // This is to remove all plots
            zedGraphControl1.GraphPane.CurveList.Clear();

            // GraphPane object holds one or more Curve objects (or plots)
            GraphPane myPane = zedGraphControl1.GraphPane;

            // PointPairList holds the data for plotting, X and Y arrays 
            PointPairList spl1 = new PointPairList(x, y);

            // Add cruves to myPane object
            LineItem myCurve1 = myPane.AddCurve("Sine Wave", spl1, Color.Blue, SymbolType.None);

            myCurve1.Line.Width = 3.0F;
            //myPane.Title.Text = "My First Plot";

            // I add all three functions just to be sure it refeshes the plot.   
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> tList = new List<String>();
            tList.Clear();
            comboBox1.Items.Clear();
            count = 0;
            foreach (string s in SerialPort.GetPortNames())
            {
                port1[count] = string.Copy(s);
                count++;
            }

            comboBox1.Items.Add("Select COM port...");

            for (int i = 0; i < count; i++)
            {
                comboBox1.Items.Add(port1[i]);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void CONNECT_Click(object sender, EventArgs e)
        {
            if (CONNECT.Text == "CONNECT")
            {
                port = new SerialPort(comboBox1.Text, baudrate, Parity.None, 8, StopBits.One);
                try
                {
                    port.Open();
                    flag = 0;
                    Recieve_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select Correct Port", ex.Message);
                    flag = 1;
                }

                if (flag == 0) CONNECT.Text = "DISCONNECT";
            }

            else if (CONNECT.Text == "DISCONNECT")
            {
                CONNECT.Text = "CONNECT";
                port.Close();
            }

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (j >= input) Reset_Click(sender, e);
            SerialPort sp = (SerialPort)sender;
            sp.Read(data1, j, 1);
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            printdata();
            datarec[j] = data1[j];
            j++;
        }

        void printdata()
        {
            if (form == 0)
            {
                Rec_data.AppendText(Convert.ToString((char)data1[j]));
                Rec_data.AppendText("\t");
            }

            else if (form == 1)
            {
                byte[] hex = new byte[2];
                hex[0] = (byte)((int)data1[j] % 16);
                hex[1] = (byte)((int)data1[j] / 16);

                if (hex[1] < (byte)10) Rec_data.AppendText(Convert.ToString(hex[1]));
                else
                {
                    hex[1] = (byte)((int)hex[1] + 55);
                    Rec_data.AppendText(Convert.ToString((char)hex[1]));
                }

                if (hex[0] < (byte)10) Rec_data.AppendText(Convert.ToString(hex[0]));
                else
                {
                    hex[0] = (byte)((int)hex[0] + 55);
                    Rec_data.AppendText(Convert.ToString((char)hex[0]));
                }

                Rec_data.AppendText("\t");
            }



            else if (form == 2)
            {
                if (j % 4 == 3)
                {
                    d += (data1[j] - 48);
                    Rec_data.AppendText(Convert.ToString(d));
                    Rec_data.AppendText("\t");
                    d = 0;
                }
                else if (j % 4 == 2)
                    d += ((data1[j] - 48) * 256);
                else if (j % 4 == 1)
                    d += ((data1[j] - 48) * 256 * 256);
                else if (j % 4 == 0)
                    d += ((data1[j] - 48) * 256 * 256 * 256);
            }
            else if (form == 3)
            {
                Rec_data.AppendText(Convert.ToString(data1[j]));
                Rec_data.AppendText("\t");
            }

        }

        private void GRAPH_Click(object sender, EventArgs e)
        {
            // Lets generate sine and cosine wave

            set_graph();

        }

        private void Send_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[2];
            data[0] = ls;
            data[1] = rs;

            port.Write(data, 0, 2);
        }

        private void Left_speed_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Leftspeed = Convert.ToUInt16(Left_speed.Text);
                ls = (byte)Leftspeed;

            }
            catch (Exception ex)
            {

            }

        }

        private void Right_speed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rightspeed = Convert.ToUInt16(Right_speed.Text);
                rs = (byte)Rightspeed;

            }
            catch (Exception ex)
            {

            }
        }


        private void Recieve_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                MessageBox.Show("Connect First");
            }
            else
            {
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < data1.Length; i++)
            {
                data1[i] = 0;
            }
            j = 0;
           
            set_graph();
        }

        private void KI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                temp = Convert.ToUInt16(KI.Text);
                ki = (byte)temp;
            }
            catch (Exception ex)
            {

            }
        }

        private void KD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                temp = Convert.ToUInt16(KD.Text);
                kd = (byte)temp;
            }
            catch (Exception ex)
            {

            }
        }

        private void KP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                temp = Convert.ToUInt16(KP.Text);
                kp = (byte)temp;
            }
            catch (Exception ex)
            {

            }
        }



        private void ASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (ASCII.Checked)
            {
                form = 0;
                HEX.Checked = false;
                INT.Checked = false;
                Uint8.Checked = false;
            }

        }

        private void HEX_CheckedChanged(object sender, EventArgs e)
        {
            if (HEX.Checked)
            {
                form = 1;
                ASCII.Checked = false;
                INT.Checked = false;
                Uint8.Checked = false;
            }
        }

        private void INT_CheckedChanged(object sender, EventArgs e)
        {
            if (INT.Checked)
            {
                form = 2;
                HEX.Checked = false;
                ASCII.Checked = false;
                Uint8.Checked = false;
            }
        }

        private void Uint8_CheckedChanged(object sender, EventArgs e)
        {
            if (Uint8.Checked)
            {
                form = 3;
                HEX.Checked = false;
                INT.Checked = false;
                ASCII.Checked = false;
            }
        }

        private void Send_KI_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];
            data[0] = ki;
            port.Write(data, 0, 1);
        }

        private void Send_KD_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];
            data[0] = kd;
            port.Write(data, 0, 1);
        }

        private void Send_KP_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];
            data[0] = kp;
            port.Write(data, 0, 1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Rec_data.Clear();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void Send_Token_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1];
            data[0] = tok;
            port.Write(data, 0, 1);
        }

        private void Token_val_TextChanged(object sender, EventArgs e)
        {
            temp = Convert.ToUInt16(KP.Text);
            tok = (byte)temp;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudrate = Convert.ToInt32(comboBox2.Text);
        }

    }
}
