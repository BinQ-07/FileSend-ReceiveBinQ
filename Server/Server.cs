using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server
{
    public partial class Server : Form
    {
        private ArrayList alSockets;
        public Server()
        {
            InitializeComponent();
        }

        public void handlerThread()
        {
            Socket handlerSocket = (Socket)alSockets[alSockets.Count - 1]; NetworkStream networkStream = new
            NetworkStream(handlerSocket);
            int thisRead = 0;
            int blockSize = 1024;
            Byte[] dataByte = new Byte[blockSize];
            lock (this)
            {
                // Only one process can access 
                // the same file at any given time 
                Stream fileStream = File.OpenWrite("D:\\Bintang\\Semester 5\\Pemrograman jaringan komputer\\FileSend-Receive\\Server\\upload.txt"); 
            while (true)
                {
                    thisRead = networkStream.Read(dataByte, 0, blockSize);
                    fileStream.Write(dataByte, 0, thisRead);
                    if (thisRead == 0) break;
                }
                fileStream.Close();
            }
            listBox1.Items.Add("File Written");
            handlerSocket = null;
        }


        public void listenerThread()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 8080);
            tcpListener.Start();
            while (true)
            {
                Socket handlerSocket = tcpListener.AcceptSocket();
                if (handlerSocket.Connected)
                {
                    listBox1.Items.Add(
                    handlerSocket.RemoteEndPoint.ToString() + " connected.");
                    lock (this)
                    {
                        alSockets.Add(handlerSocket);
                    }
                    ThreadStart thdstHandler = new
                   ThreadStart(handlerThread);
                    Thread thdHandler = new Thread(thdstHandler); thdHandler.Start();
                }
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            label1.Text = "My IP address is " +
            IPHost.AddressList[0].ToString();
            alSockets = new ArrayList();
            Thread thdListener = new Thread(new
            ThreadStart(listenerThread));
            thdListener.Start();
        }
    }

}
