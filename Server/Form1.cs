using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{

    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        SimpleTcpClient sending;
        String msg;

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
            answer.Text += "Server starting...";
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            server.Start(ip, Convert.ToInt32("8910"));
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            answer.Invoke((MethodInvoker)delegate()
            {
                String data = e.MessageString;
                Console.WriteLine(data+" "+ e.MessageString[0]);
                data = data.Substring(1);
                if (e.MessageString[0] =='0')
                {
                    text.Text = data;
                }
                if (e.MessageString[0] == '1')
                {
                    answer.Text = data;
                    msg = data;
                }
                if (e.MessageString[0] == '2')
                {
                   
                    text3.Text = data;
                }
                e.ReplyLine(string.Format("You said: {0}", "ok"));

            });
        }

        private void send_Click(object sender, EventArgs e)
        {
            sending = new SimpleTcpClient();
            sending.StringEncoder = Encoding.UTF8;
            sending.DataReceived += Server_DataReceived;
            sending.Connect("127.0.0.1", Convert.ToInt32("9080"));
            //BigInteger privat = pq.encryptionKeyFind((int)pq.getN());
            string[] ar = text3.Text.Split(',');
            sending.WriteLineAndGetReply("0" + text.Text, TimeSpan.FromSeconds(2));
            sending.WriteLineAndGetReply("1" + msg, TimeSpan.FromSeconds(2));
            sending.WriteLineAndGetReply("2" + answer.Text, TimeSpan.FromSeconds(2));
            sending.WriteLineAndGetReply("3" + text3.Text, TimeSpan.FromSeconds(2));
        }
    }
}
