using System;
using System.Collections.Generic;
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
using System.Text;
using System.IO;


namespace Client
{
    public partial class FileSRClient : Form
    {
        public FileSRClient()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            file_dir.Text = openFileDialog1.FileName;
        }

        private void send_Click(object sender, EventArgs e)
        {
            Stream fileStream = File.OpenRead(file_dir.Text);
            // Alocate memory space for the file
            byte[] fileBuffer = new byte[fileStream.Length];
            fileStream.Read(fileBuffer, 0, (int)fileStream.Length);
            // Open a TCP/IP Connection and send the data
            TcpClient clientSocket = new TcpClient(serv_adrs.Text, 8080);
            NetworkStream networkStream = clientSocket.GetStream();
            networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
            networkStream.Close();
        }
    }
}
