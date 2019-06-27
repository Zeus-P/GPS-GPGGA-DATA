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
using System.IO;

namespace GPS
{
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
        }
        
        public void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                //serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                
                serialPort1.Open();
                progressBar1.Value = 100;

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        //{
        //    try
        //    {
        //        SerialPort sp = (SerialPort)sender;
        //        string dataIN = sp.ReadExisting();
        //    }
        //    catch(Exception err)
        //    {
        //        Console.WriteLine(err);
        //    }
        //}
        public void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void Abhishek(object sender, EventArgs e)
        {
            //data = serialPort1.ReadLine();
            data = serialPort1.ReadLine();
            using (StreamWriter sr = File.AppendText(@"C:\Users\sudarshan.kumar\Desktop\Student\gps.txt"))
            {
                sr.WriteLine(data);
                sr.Close();
            }
        }

        private void btnGetGPSData_Click_1(object sender, EventArgs e)
        {
            
            //timer1_Tick(sender, e);
            if (!string.IsNullOrEmpty(data))
            {
                string message = data;
                tBoxDataIN.Text = message;
            }

            else
            {
                tBoxDataIN.Text = "No Data Received";
            }

            string gpsdata = tBoxDataIN.Text;
            splitdata(data);
        }

        public void splitdata(string data)
        {
            try
            {
                //StreamReader sr = new System.IO.StreamReader(gpsdata);
                //string str = sr.ReadLine();
                
                for (int i = 0; i <= data.Length; i++)
                {
                    string temp = data;
                    string debug = temp;
                    string[] lineArr = temp.Split(',');

                    if (lineArr[0] == "$GPGGA")
                    {
                        try
                        {
                            //Latitude
                            if (lineArr.Length >= 7 && lineArr[2] != "")
                            {
                                double converted = Convert.ToDouble(lineArr[2]) / 100;
                                string[] lat = converted.ToString().Split('.');
                                string altered = lat[1] + "000000000000000000000000";
                                double me = Convert.ToDouble(lat[0].ToString()) + ((Convert.ToDouble(altered.Substring(0, 6)) / 60)) / 10000;
                                tBoxLatitude.Text = lineArr[3].ToString() + me.ToString();



                                //Longitude
                                double converted1 = Convert.ToDouble(lineArr[4]) / 100;
                                string[] lon = converted1.ToString().Split('.');
                                string altered1 = lon[1] + "000000000000000000000000";
                                double me1 = Convert.ToDouble(lon[0].ToString()) + ((Convert.ToDouble(altered1.Substring(0, 6)) / 60)) / 10000;
                                tBoxLongitude.Text = lineArr[5].ToString() + me1.ToString();


                                //Time
                                string time = lineArr[1][0].ToString() + lineArr[1][1].ToString();
                                tBoxUTC.Text = time;


                                //Altitude
                                if (lineArr.Length >= 10)
                                {
                                    tBoxAltitude.Text = lineArr[9].ToString();
                                }
                                //Heading
                                string head = lineArr[0].ToString();
                                tBoxHeading.Text = head;
                            }
                        }
                        catch (Exception)
                        {
                            tBoxDataIN.Text = "Exception Occured";
                        }
                    }
                }
              }
                    catch(Exception)
                    {
                        Console.WriteLine("error");
                    }
            }

        private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            tBoxDataIN.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (StreamWriter sr = File.AppendText(@"C:\Users\sudarshan.kumar\Desktop\Student\data.txt"))
            {
                sr.WriteLine("Latitude : ");
                sr.WriteLine(tBoxLatitude+"\n");
                sr.WriteLine("Longitude : ");
                sr.WriteLine(tBoxLongitude + "\n");
                sr.WriteLine("Altitude : ");
                sr.WriteLine(tBoxAltitude + "\n");
                sr.WriteLine("UTC : ");
                sr.WriteLine(tBoxUTC + "\n");
                sr.WriteLine("Heading : ");
                sr.WriteLine(tBoxHeading + "\n");
                sr.WriteLine("\n");

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tBoxLatitude.Text= "";
            tBoxLongitude.Text = "";
            tBoxAltitude.Text = "";
            tBoxUTC.Text = "";
            tBoxHeading.Text = "";
        }
    }
}