using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace receiver
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DelimiterDataReceived += Server_DataReceived;
            text.Text += "Server starting...";
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            server.Start(ip, Convert.ToInt32("9080"));
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            text.Invoke((MethodInvoker)delegate ()
            {
                String data = e.MessageString;
                Console.WriteLine(data + " " + e.MessageString[0]);
                data = data.Substring(1);
                if (e.MessageString[0] == '0')
                {
                    text.Text = data;
                }
                if (e.MessageString[0] == '1')
                {
                    text2.Text = data;
                }
                if (e.MessageString[0] == '2')
                {

                    text4.Text = data;
                }
                e.ReplyLine(string.Format("You said: {0}", "ok"));

            });
        }
    }
}
