using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace vpn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Server" && radioButton1.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpnserv.exe";
                startInfo.Arguments = "--config server.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("You are connecting to server with UDP");
            }
            else if(comboBox2.Text == "Server" && radioButton2.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpnserv.exe";
                startInfo.Arguments = "--config server.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("You are connecting to server with TCP");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/f /im openvpn.exe",
                CreateNoWindow = true,
                UseShellExecute = false,

            }).WaitForExit();
        }
    }
}
//for that project I was using openserv, to make it work download it and configure your settings(config.file)