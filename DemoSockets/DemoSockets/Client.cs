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



namespace DemoSockets
{
    public partial class Client : Form
    {
        Socket _cSock = null;

        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cSock = new Socket(
                AddressFamily.InterNetwork, // IP V4 address scheme
                SocketType.Stream, // streaming socket (connection-based)
                ProtocolType.Tcp
            ); // TCP protocol
        }
    }
}
