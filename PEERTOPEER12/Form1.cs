using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace PEERTOPEER12
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;

        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextbox.Text = address.ToString();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPortsTextbox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;




            //string host = System.Net.Dns.GetHostName();
            //System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostByName(host);
            //string IpAdresse = hostInfo.AddressList[0].ToString();
            //ServerIPtextbox.Text = IpAdresse + "    "+ host;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(ClientIPTextbox.Text), int.Parse(ClientPortsTextbox.Text));

            try
            {
                ChatScreen.AppendText("Connect To Server" + "\n");
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                    {

                        ChatScreen.AppendText("You: " + recieve + "\n");

                    }));
                    recieve = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreen.AppendText("Me" + TextToSend + "\n");


                }));
            }
             else
                {
                MessageBox.Show("Sending Failed");


                }
            backgroundWorker2.CancelAsync();

            }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if(Messagebox.Text !="")
            {
                TextToSend = Messagebox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            Messagebox.Text = "";
        }
    }
}
