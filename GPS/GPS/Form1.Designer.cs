namespace GPS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBoxComPortControl = new System.Windows.Forms.GroupBox();
            this.L_parity = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.L_stopbits = new System.Windows.Forms.Label();
            this.L_databits = new System.Windows.Forms.Label();
            this.L_baudrate = new System.Windows.Forms.Label();
            this.L_portname = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.L_Latitude = new System.Windows.Forms.Label();
            this.L_Longitude = new System.Windows.Forms.Label();
            this.L_Altitude = new System.Windows.Forms.Label();
            this.L_UTC = new System.Windows.Forms.Label();
            this.L_Heading = new System.Windows.Forms.Label();
            this.tBoxLatitude = new System.Windows.Forms.TextBox();
            this.tBoxLongitude = new System.Windows.Forms.TextBox();
            this.tBoxAltitude = new System.Windows.Forms.TextBox();
            this.tBoxUTC = new System.Windows.Forms.TextBox();
            this.tBoxHeading = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gBoxOpenClose = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gBoxReceiver = new System.Windows.Forms.GroupBox();
            this.gBoxDataGps = new System.Windows.Forms.GroupBox();
            this.btnGetGPSData = new System.Windows.Forms.Button();
            this.btnClearDataIN = new System.Windows.Forms.Button();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gBoxComPortControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gBoxOpenClose.SuspendLayout();
            this.gBoxReceiver.SuspendLayout();
            this.gBoxDataGps.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxComPortControl
            // 
            this.gBoxComPortControl.Controls.Add(this.L_parity);
            this.gBoxComPortControl.Controls.Add(this.cBoxParityBits);
            this.gBoxComPortControl.Controls.Add(this.L_stopbits);
            this.gBoxComPortControl.Controls.Add(this.L_databits);
            this.gBoxComPortControl.Controls.Add(this.L_baudrate);
            this.gBoxComPortControl.Controls.Add(this.L_portname);
            this.gBoxComPortControl.Controls.Add(this.cBoxStopBits);
            this.gBoxComPortControl.Controls.Add(this.cBoxDataBits);
            this.gBoxComPortControl.Controls.Add(this.cBoxBaudRate);
            this.gBoxComPortControl.Controls.Add(this.cBoxCOMPORT);
            this.gBoxComPortControl.Location = new System.Drawing.Point(12, 12);
            this.gBoxComPortControl.Name = "gBoxComPortControl";
            this.gBoxComPortControl.Size = new System.Drawing.Size(232, 164);
            this.gBoxComPortControl.TabIndex = 0;
            this.gBoxComPortControl.TabStop = false;
            this.gBoxComPortControl.Text = "Com Port Control";
            // 
            // L_parity
            // 
            this.L_parity.AutoSize = true;
            this.L_parity.Location = new System.Drawing.Point(17, 137);
            this.L_parity.Name = "L_parity";
            this.L_parity.Size = new System.Drawing.Size(53, 13);
            this.L_parity.TabIndex = 11;
            this.L_parity.Text = "Parity Bits";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(92, 132);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(120, 21);
            this.cBoxParityBits.TabIndex = 10;
            this.cBoxParityBits.Text = "None";
            // 
            // L_stopbits
            // 
            this.L_stopbits.AutoSize = true;
            this.L_stopbits.Location = new System.Drawing.Point(17, 109);
            this.L_stopbits.Name = "L_stopbits";
            this.L_stopbits.Size = new System.Drawing.Size(49, 13);
            this.L_stopbits.TabIndex = 9;
            this.L_stopbits.Text = "Stop Bits";
            // 
            // L_databits
            // 
            this.L_databits.AutoSize = true;
            this.L_databits.Location = new System.Drawing.Point(17, 81);
            this.L_databits.Name = "L_databits";
            this.L_databits.Size = new System.Drawing.Size(50, 13);
            this.L_databits.TabIndex = 8;
            this.L_databits.Text = "Data Bits";
            // 
            // L_baudrate
            // 
            this.L_baudrate.AutoSize = true;
            this.L_baudrate.Location = new System.Drawing.Point(17, 53);
            this.L_baudrate.Name = "L_baudrate";
            this.L_baudrate.Size = new System.Drawing.Size(58, 13);
            this.L_baudrate.TabIndex = 7;
            this.L_baudrate.Text = "Baud Rate";
            // 
            // L_portname
            // 
            this.L_portname.AutoSize = true;
            this.L_portname.Location = new System.Drawing.Point(17, 25);
            this.L_portname.Name = "L_portname";
            this.L_portname.Size = new System.Drawing.Size(61, 13);
            this.L_portname.TabIndex = 6;
            this.L_portname.Text = "COMPORT";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(92, 104);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(120, 21);
            this.cBoxStopBits.TabIndex = 5;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(92, 76);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxDataBits.TabIndex = 4;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(92, 48);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudRate.TabIndex = 3;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(92, 20);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.cBoxCOMPORT.TabIndex = 2;
            this.cBoxCOMPORT.Text = "COM1";
            // 
            // L_Latitude
            // 
            this.L_Latitude.AutoSize = true;
            this.L_Latitude.Location = new System.Drawing.Point(59, 34);
            this.L_Latitude.Name = "L_Latitude";
            this.L_Latitude.Size = new System.Drawing.Size(45, 13);
            this.L_Latitude.TabIndex = 0;
            this.L_Latitude.Text = "Latitude";
            // 
            // L_Longitude
            // 
            this.L_Longitude.AutoSize = true;
            this.L_Longitude.Location = new System.Drawing.Point(59, 69);
            this.L_Longitude.Name = "L_Longitude";
            this.L_Longitude.Size = new System.Drawing.Size(54, 13);
            this.L_Longitude.TabIndex = 1;
            this.L_Longitude.Text = "Longitude";
            // 
            // L_Altitude
            // 
            this.L_Altitude.AutoSize = true;
            this.L_Altitude.Location = new System.Drawing.Point(59, 107);
            this.L_Altitude.Name = "L_Altitude";
            this.L_Altitude.Size = new System.Drawing.Size(42, 13);
            this.L_Altitude.TabIndex = 2;
            this.L_Altitude.Text = "Altitude";
            // 
            // L_UTC
            // 
            this.L_UTC.AutoSize = true;
            this.L_UTC.Location = new System.Drawing.Point(59, 143);
            this.L_UTC.Name = "L_UTC";
            this.L_UTC.Size = new System.Drawing.Size(29, 13);
            this.L_UTC.TabIndex = 3;
            this.L_UTC.Text = "UTC";
            // 
            // L_Heading
            // 
            this.L_Heading.AutoSize = true;
            this.L_Heading.Location = new System.Drawing.Point(59, 181);
            this.L_Heading.Name = "L_Heading";
            this.L_Heading.Size = new System.Drawing.Size(47, 13);
            this.L_Heading.TabIndex = 4;
            this.L_Heading.Text = "Heading";
            // 
            // tBoxLatitude
            // 
            this.tBoxLatitude.Location = new System.Drawing.Point(132, 26);
            this.tBoxLatitude.Multiline = true;
            this.tBoxLatitude.Name = "tBoxLatitude";
            this.tBoxLatitude.Size = new System.Drawing.Size(358, 31);
            this.tBoxLatitude.TabIndex = 5;
            // 
            // tBoxLongitude
            // 
            this.tBoxLongitude.Location = new System.Drawing.Point(132, 63);
            this.tBoxLongitude.Multiline = true;
            this.tBoxLongitude.Name = "tBoxLongitude";
            this.tBoxLongitude.Size = new System.Drawing.Size(358, 31);
            this.tBoxLongitude.TabIndex = 6;
            // 
            // tBoxAltitude
            // 
            this.tBoxAltitude.Location = new System.Drawing.Point(132, 100);
            this.tBoxAltitude.Multiline = true;
            this.tBoxAltitude.Name = "tBoxAltitude";
            this.tBoxAltitude.Size = new System.Drawing.Size(358, 31);
            this.tBoxAltitude.TabIndex = 7;
            // 
            // tBoxUTC
            // 
            this.tBoxUTC.Location = new System.Drawing.Point(132, 137);
            this.tBoxUTC.Multiline = true;
            this.tBoxUTC.Name = "tBoxUTC";
            this.tBoxUTC.Size = new System.Drawing.Size(358, 31);
            this.tBoxUTC.TabIndex = 8;
            // 
            // tBoxHeading
            // 
            this.tBoxHeading.Location = new System.Drawing.Point(132, 174);
            this.tBoxHeading.Multiline = true;
            this.tBoxHeading.Name = "tBoxHeading";
            this.tBoxHeading.Size = new System.Drawing.Size(358, 31);
            this.tBoxHeading.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.tBoxHeading);
            this.groupBox3.Controls.Add(this.tBoxUTC);
            this.groupBox3.Controls.Add(this.tBoxAltitude);
            this.groupBox3.Controls.Add(this.tBoxLongitude);
            this.groupBox3.Controls.Add(this.tBoxLatitude);
            this.groupBox3.Controls.Add(this.L_Heading);
            this.groupBox3.Controls.Add(this.L_UTC);
            this.groupBox3.Controls.Add(this.L_Altitude);
            this.groupBox3.Controls.Add(this.L_Longitude);
            this.groupBox3.Controls.Add(this.L_Latitude);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 250);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPS Data";
            // 
            // gBoxOpenClose
            // 
            this.gBoxOpenClose.Controls.Add(this.progressBar1);
            this.gBoxOpenClose.Controls.Add(this.btnClose);
            this.gBoxOpenClose.Controls.Add(this.btnOpen);
            this.gBoxOpenClose.Location = new System.Drawing.Point(12, 182);
            this.gBoxOpenClose.Name = "gBoxOpenClose";
            this.gBoxOpenClose.Size = new System.Drawing.Size(160, 91);
            this.gBoxOpenClose.TabIndex = 2;
            this.gBoxOpenClose.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(141, 27);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(80, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gBoxReceiver
            // 
            this.gBoxReceiver.Controls.Add(this.gBoxDataGps);
            this.gBoxReceiver.Controls.Add(this.tBoxDataIN);
            this.gBoxReceiver.Location = new System.Drawing.Point(250, 12);
            this.gBoxReceiver.Name = "gBoxReceiver";
            this.gBoxReceiver.Size = new System.Drawing.Size(332, 246);
            this.gBoxReceiver.TabIndex = 5;
            this.gBoxReceiver.TabStop = false;
            this.gBoxReceiver.Text = "Receiver Control";
            // 
            // gBoxDataGps
            // 
            this.gBoxDataGps.Controls.Add(this.btnGetGPSData);
            this.gBoxDataGps.Controls.Add(this.btnClearDataIN);
            this.gBoxDataGps.Location = new System.Drawing.Point(7, 163);
            this.gBoxDataGps.Name = "gBoxDataGps";
            this.gBoxDataGps.Size = new System.Drawing.Size(311, 73);
            this.gBoxDataGps.TabIndex = 1;
            this.gBoxDataGps.TabStop = false;
            // 
            // btnGetGPSData
            // 
            this.btnGetGPSData.Location = new System.Drawing.Point(7, 14);
            this.btnGetGPSData.Name = "btnGetGPSData";
            this.btnGetGPSData.Size = new System.Drawing.Size(87, 52);
            this.btnGetGPSData.TabIndex = 3;
            this.btnGetGPSData.Text = "Get GPS Data";
            this.btnGetGPSData.UseVisualStyleBackColor = true;
            this.btnGetGPSData.Click += new System.EventHandler(this.btnGetGPSData_Click_1);
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.Location = new System.Drawing.Point(226, 12);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(79, 52);
            this.btnClearDataIN.TabIndex = 0;
            this.btnClearDataIN.Text = "Clear Data IN";
            this.btnClearDataIN.UseVisualStyleBackColor = true;
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(6, 19);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(312, 144);
            this.tBoxDataIN.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            //this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(589, 537);
            this.Controls.Add(this.gBoxReceiver);
            this.Controls.Add(this.gBoxOpenClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gBoxComPortControl);
            this.Name = "Form1";
            this.Text = "Serial Port Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxComPortControl.ResumeLayout(false);
            this.gBoxComPortControl.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gBoxOpenClose.ResumeLayout(false);
            this.gBoxReceiver.ResumeLayout(false);
            this.gBoxReceiver.PerformLayout();
            this.gBoxDataGps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxComPortControl;
        private System.Windows.Forms.Label L_stopbits;
        private System.Windows.Forms.Label L_databits;
        private System.Windows.Forms.Label L_baudrate;
        private System.Windows.Forms.Label L_portname;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label L_parity;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.Label L_Latitude;
        private System.Windows.Forms.Label L_Longitude;
        private System.Windows.Forms.Label L_Altitude;
        private System.Windows.Forms.Label L_UTC;
        private System.Windows.Forms.Label L_Heading;
        private System.Windows.Forms.TextBox tBoxLatitude;
        private System.Windows.Forms.TextBox tBoxLongitude;
        private System.Windows.Forms.TextBox tBoxAltitude;
        private System.Windows.Forms.TextBox tBoxUTC;
        private System.Windows.Forms.TextBox tBoxHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gBoxOpenClose;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gBoxReceiver;
        private System.Windows.Forms.GroupBox gBoxDataGps;
        private System.Windows.Forms.Button btnClearDataIN;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Button btnGetGPSData;
        private System.Windows.Forms.Timer timer1;
    }
}

