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

namespace receiverr
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

                    text3.Text = data;
                }
                if (e.MessageString[0] == '3')
                {

                    text4.Text = data;
                    asi();
                }
               
            });
          
           

        }
        private void asi()
        {

            pgGeneration pq = new pgGeneration();
            string[] ar = text4.Text.Split(',');
            Console.WriteLine("***********"+ar[1]);
            pq.setE(BigInteger.Parse(ar[1]));
            BigInteger privat = pq.encryptionKeyFind(int.Parse(ar[0]));

            string[] tx = text3.Text.Split(' ');
            string t = null;
            BigInteger[] encode = new BigInteger[tx.Length];
            Console.WriteLine(tx[0] + " d " + privat+ "n= " + " ar[0]" + ar[0] + " " + tx.Length);
            for (int i = 0; i < tx.Length-1; i++)
            {

                encode[i] = BigInteger.Pow(int.Parse(tx[i]), int.Parse(ar[1])) % BigInteger.Parse(ar[0]);
                Console.WriteLine(encode[i]);


            }
            bool itIsTrue = true;
            string[] simple = text.Text.Split(' ');
            for (int i=0; i< encode.Length-1; i++)
            {
                if (encode[i].ToString() != simple[i]) itIsTrue = false;
                Console.WriteLine(encode[i]+" "+ simple[i]);
            }
            if (itIsTrue == false) signature.Text="Parašas nepatvirtintas";
            else { signature.Text = "Parašas patvirtintas"; }
        }
    }
}
