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

namespace Saugumo_5uzd
{
    public partial class Form1 : Form
    {
        SimpleTcpClient send;
        public Form1()
        {
            InitializeComponent();
 
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            answer.Invoke((MethodInvoker)delegate()
            {
               
                //answer.Text += e.MessageString;
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            send = new SimpleTcpClient();
            send.StringEncoder = Encoding.UTF8;
            send.DataReceived += Server_DataReceived;
            send.Connect("127.0.0.1", Convert.ToInt32("8910"));
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            pqgeneration pq = new pqgeneration();

            pq.findE();
            Console.WriteLine("p= " + pq.getP() + " q= " + pq.getQ() + " fn= " + pq.getfn() + "n= " + pq.getN() + " e= " + pq.getE());
            BigInteger d = pq.privatusRaktas();
         
       
            int[] txt = pq.getKodas(text.Text);
            string t = null;
            BigInteger[] encode = new BigInteger[txt.Length];
            for (int i = 0; i < txt.Length; i++)
            {
                t = t+ txt[i]+" ";
                encode[i] = BigInteger.Pow(txt[i], (int)d) % pq.getN();

            }
            answer.Text = "Pradinis tekstas: "+t;
            send.WriteLineAndGetReply("0"+t, TimeSpan.FromSeconds(2));
            t = null;
            for (int i = 0; i < encode.Length; i++)
            {
                t = t + encode[i] + " ";
            }
            answer.Text = answer.Text + System.Environment.NewLine + "Paraso tekstas: "+t;
            send.WriteLineAndGetReply("1" + t, TimeSpan.FromSeconds(2));
            answer.Text = answer.Text+ System.Environment.NewLine+ "Viesas raktas n= " + pq.getN()+" e= "+ pq.getE();
            send.WriteLineAndGetReply("2" + pq.getN()+","+ pq.getE()+"", TimeSpan.FromSeconds(2));
            answer.Text = answer.Text + System.Environment.NewLine + "Privatus raktas d= " + d;

        }

    }
}
