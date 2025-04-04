using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace CryptoChat2142
{
    public partial class Client : Form
    {
        // this will be our connected socket
        private TcpClient _tcpClient = null;

        public Client()
        {
            InitializeComponent();
        }

        private async void UI_B_Connect_Click(object sender, EventArgs e)
        {
            // attempt to connect the socket
            _tcpClient = new TcpClient();
            await _tcpClient.ConnectAsync("localhost", 1666);
            Console.WriteLine("Connected!");

            // send hello message on connect
            byte[] buff = Encoding.ASCII.GetBytes("Hello!");
            NetworkStream ns = _tcpClient.GetStream();
            await ns.WriteAsync (buff, 0, buff.Length);
        }

        private async void UI_B_Send_Click(object sender, EventArgs e)
        {
            // if a connection has been formed, encode and send the desired string
            if (_tcpClient != null &&  _tcpClient.Connected)
            {
                byte[] buff = Encoding.ASCII.GetBytes(UI_TB_Message.Text);

                // pull out and use the stream from the socket
                NetworkStream ns = _tcpClient.GetStream();
                await ns.WriteAsync(buff, 0, buff.Length);
            }
        }
    }
}
