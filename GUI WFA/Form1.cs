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
using System.Threading;

namespace GUI_WFA
{
    public partial class Form1 : Form
    {
        string dataIn;      //stores the data received from adruino

        public Form1()
        {
            InitializeComponent();
            deg1Out.Text = "";      //clears the motor values shown
            deg2Out.Text = "";
        }


        private void cnctBtn_Click(object sender, EventArgs e)      //connect button event
        {
            try         //exception handling
            {
                if (cnctBtn.Text == "Connect")      //if the text on the button "connect"
                {
                    if (portList.Text == "")        //if there is no port chosen
                    {
                        MessageBox.Show("please choose the port");      //show message
                    }
                    else
                    {
                        serialPort1.PortName = portList.Text;       //if port chosen
                        serialPort1.BaudRate = 9600;
                        serialPort1.Open();                         //connect to port
                        cnctBtn.Text = "Disconnect";                //change the text on the button
                        portList.Enabled = false;                   //disable port changing
                    }
                }
                else                                                //if the text on the button "disconnect"
                {
                    serialPort1.Close();                            //close the port "disconnect"
                    cnctBtn.Text = "Connect";                       //change the text on the button
                    portList.Enabled = true;                        //enable port selection
                }
            }
            catch (UnauthorizedAccessException)                     //exception handling
            {
               MessageBox.Show("UnauthorizedAccessException", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(System.IO.IOException)
            {
                MessageBox.Show("Port does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set1_Click(object sender, EventArgs e)     //set motor 1 button event
        {
            try
            {
                serialPort1.Write("m" + numericUpDown1.Value.ToString());     //write the value of motor1 in the serial port
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("port is closed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)    //angle 1 value arrow keys event
        {
            try
            {
                serialPort1.Write("m" + numericUpDown1.Value.ToString());   //write the value of motor1 in the serial port
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("port is closed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set2_Click(object sender, EventArgs e)     //set motor 2 button event
        {
            try
            {
                serialPort1.Write("M" + numericUpDown2.Value.ToString());   //write the value in the serial port
            }
            catch (Exception)
            {
                MessageBox.Show("port is closed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)    //angle 2 value arrow keys event
        {
            try
            {
                serialPort1.Write("M" + numericUpDown2.Value.ToString());    //write the value of motor2 in the serial port
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("port is closed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void portList_DropDown(object sender, EventArgs e)      //ports list drop down event
        {
            String[] ports = SerialPort.GetPortNames();     //get avilable ports names
            portList.Items.Clear();                         //clears the port list
            portList.Items.AddRange(ports);                 //adds new ports list
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)     //serial receiving event
        {
            try
            {
                dataIn = serialPort1.ReadLine();        //stores the read data from serial port
                
                if (dataIn.Contains('m'))               //reads angle value for motor 1
                {
                    deg1Out.BeginInvoke(new Action(() => deg1Out.Text = dataIn.Substring(1) + " degrees")); //changes displayed angle 1
                }
                else if (dataIn.Contains('M'))          //reads angle value for motor 2
                {
                    deg2Out.BeginInvoke(new Action(() => deg2Out.Text = dataIn.Substring(1) + " degrees")); //changes displayed angle 2
                }
            }
            catch
            {
                MessageBox.Show("Error reading serial port", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)       //form resizing event
        {       //resizes fonts of all elements according to the form hieght
            if (Size.Height > 50)
            {
                m1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                m2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                deg1Out.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                deg2Out.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                set1.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                set2.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                ports.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);

                numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                portList.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);
                cnctBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", (Size.Height / 275) * 15F);

                portList.Margin = new System.Windows.Forms.Padding(4, (Size.Height / 275) * 20, 4, 3);
            }
        }
    }
}
