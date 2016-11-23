using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace GeneralLogger
{
    public partial class GeneralLogger : Form
    {

        private SerialPort _serialPort;

        string prefixVsim   = "SERIAL:\t";
        string prefixLogcat = "LOGCAT:\t";
        string captureLogcat = "True";
        public GeneralLogger()
        {
            InitializeComponent();
            this.Icon = new Icon("gl.ico");
            this.Text = "GeneralLogger V1.0.0";

            InitPortOptions();
            prefixVsim = comboBoxPrefix.Text;
            prefixLogcat = comboBoxPrefixLogcat.Text;

        }
        public void InitPortOptions()
        {
            comboBoxCom.Items.AddRange(SerialPort.GetPortNames());
            comboBoxBaudRate.Text = "230400";
            comboBoxBaudRate.Items.AddRange(new string[]
            {
                "4800",
                "9600",
                "19200",
                "38400",
                "56000",
                "57600",
                "115200",
                "230400"
            });


            comboBoxBitSet.Text = "8";
            comboBoxBitSet.Items.AddRange(new string[] { "8", "9" });


            comboBoxPrefix.Text = "SERIAL:\t";
            comboBoxPrefix.Items.AddRange(new string[]
                {"",
                "SER:\t",
                "SerialMonitor:\t"}
                );

            comboBoxPrefixLogcat.Text = "LOGCAT:\t";
            comboBoxPrefixLogcat.Items.AddRange(new string[]
                {"",
                "LGC:\t",
                "LogcatMonitor:\t"}
                );

            comboBoxCaptureLogcat.Text = "True";
            comboBoxCaptureLogcat.Items.AddRange(new string[]
                {"True",
                "False"}
                );

        }
        private void OpenPort()
        {
            try
            {
                //refreshLogcat.BackColor = Color.Lime;
                _serialPort = new SerialPort(comboBoxCom.Text,
                                            int.Parse(comboBoxBaudRate.Text),
                                            Parity.None,
                                            int.Parse(comboBoxBitSet.Text),
                                            StopBits.One);
                _serialPort.Open();
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
                ToggleButtons();

                if (captureLogcat == "True")
                {
                    ProcessStartInfo logcat = new ProcessStartInfo
                    {
                        FileName = "adb",
                        Arguments = "logcat",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    };

                    Process proc = Process.Start(logcat);

                    Thread thread = new Thread(() =>
                    {
                        while (!proc.StandardOutput.EndOfStream)
                        {
                            string line = proc.StandardOutput.ReadLine();
                            if (line != "")
                            {
                                Trace.Write(prefixLogcat + line);
                                Thread.Sleep(1);
                            }
                        }
                    });
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to open port");
            }
        }


        void ToggleButtons()
        {
            buttonOpenPort.Enabled = !buttonOpenPort.Enabled;
            buttonClosePort.Enabled = !buttonClosePort.Enabled;
            comboBoxCom.Enabled = !comboBoxCom.Enabled;
            comboBoxBaudRate.Enabled = !comboBoxBaudRate.Enabled;
            comboBoxBitSet.Enabled = !comboBoxBitSet.Enabled;
            comboBoxPrefix.Enabled = !comboBoxPrefix.Enabled;
            comboBoxPrefixLogcat.Enabled = !comboBoxPrefixLogcat.Enabled;
            comboBoxCaptureLogcat.Enabled = !comboBoxCaptureLogcat.Enabled;
            refreshLogcat.Enabled = true;
        }
        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            prefixVsim = comboBoxPrefix.Text;
            prefixLogcat = comboBoxPrefixLogcat.Text;
            captureLogcat = comboBoxCaptureLogcat.Text;
            OpenPort();

        }
        
        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            ToggleButtons();
        }
        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Trace.Write(prefixVsim + _serialPort.ReadLine());
            //Thread.Sleep(1);
        }

        private void GeneralLogger_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo logcat = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = "logcat",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process proc = Process.Start(logcat);

            Thread thread = new Thread(() =>
            {
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    if (line != "")
                    {
                        Trace.Write(prefixLogcat + line);
                        Thread.Sleep(1);
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo reboot = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = "reboot",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process procReboot = Process.Start(reboot);

            /* wait a bit and restart the logcat */
            Thread.Sleep(10000);

            ProcessStartInfo logcat = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = "logcat",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process proc = Process.Start(logcat);

            Thread thread = new Thread(() =>
            {
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    if (line != "")
                    {
                        Trace.Write(prefixLogcat + line);
                        Thread.Sleep(1);
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
