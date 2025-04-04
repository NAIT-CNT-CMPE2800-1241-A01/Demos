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

namespace CryptoChatServer
{
    public partial class Server : Form
    {
        // server needs a listener to create connections
        private TcpListener _listener = null;

        // this will be the actual connected socket
        private TcpClient _client = null;

        public Server()
        {
            InitializeComponent();
        }

        private async void Server_Load(object sender, EventArgs e)
        {
            // on load, start the listener, and wait for a connection
            //  keep in mind this task will give up control while waiting for a connection
            await Task.Run (GoListen);
        }

        private async void StartRx ()
        {
            // this should only be started after a connection is made
            while (_client.Connected)
            {
                // pull the stream out of the socket, use it for reading data
                NetworkStream ns = _client.GetStream();
                byte[] buffer = new byte[2000];
                
                // wait for data to arrive
                int iRead = await ns.ReadAsync(buffer, 0, 2000);
                Console.WriteLine($"read {iRead} bytes!");
                Text = Encoding.UTF8.GetString(buffer, 0, iRead);
            }
        }

        private async void GoListen ()
        {
            // create the listener, any interface, port 1666, and start it
            _listener = new TcpListener(new System.Net.IPEndPoint (System.Net.IPAddress.Any, 1666));
            _listener.Start();
            Console.WriteLine("started listener");

            // wait for a connection attempt, saving the connected socket
            _client = await _listener.AcceptTcpClientAsync();
            Console.WriteLine("got connection");

            // kill the listener
            _listener.Stop();

            // start the process of receiving
            Invoke(new Action(StartRx));
        }
    }
}
