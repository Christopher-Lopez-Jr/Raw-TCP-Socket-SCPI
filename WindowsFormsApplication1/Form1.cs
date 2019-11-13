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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static AsyncCallback m_pCallBackFunc;
        static string m_AsyncReply;
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            string ip = txtIP.Text;
            Int32 port = Int32.Parse(txtPort.Text);
            string server;
            try
            {
               
                IPHostEntry hostInfo = Dns.Resolve(ip);
                IPAddress[] IPAddresses = hostInfo.AddressList;

                IPEndPoint endpoint1 = new IPEndPoint(IPAddresses[0], port);
                client.Connect(endpoint1);
                txtSent.Text = "Connected!";
                if (!client.Connected) { } else { 
                    //txtSent.Text = "Connected!";
                }


                

            }catch(Exception ex){

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //txtSent.Text = "";
            Console.WriteLine("Hello");
            //string id = Parse(client,"*IDN?");
            string command = inputSCPI.Text;
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(command);
            client.Send(data);
            txtSent.Text = "Sent!";
            Byte[] lf = System.Text.Encoding.ASCII.GetBytes("/n");

            client.Send(lf);
            txtSent.Text = "Sent:" + command;
         /*   Byte[] datas = new Byte[256];
            Int32 byteCount = client.Receive(datas);
            string responseData = System.Text.Encoding.ASCII.GetString(datas, 0, byteCount);
            textBox2.Text = responseData;*/
           if (command.IndexOf("?") >= 0)
            {
                Byte[] datas = new Byte[256];
                Int32 byteCount = client.Receive(datas);
                string responseData = System.Text.Encoding.ASCII.GetString(datas, 0, byteCount);
                textBox2.Text = responseData;
            }
        }

        private void inputSCPI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
