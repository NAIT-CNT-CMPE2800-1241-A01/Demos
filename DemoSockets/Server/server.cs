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

namespace Server
{
    public partial class server : Form
    {
        private Socket _lSocket = null;
        private Socket _cSocket = null;

        public server()
        {
            InitializeComponent();
        }

        private void server_Load(object sender, EventArgs e)
        {

            _lSocket = new Socket(
                AddressFamily.InterNetwork, // IP V4 address scheme
                SocketType.Stream, // streaming socket (connection-based)
                ProtocolType.Tcp);

            // create the soon to be listening socket
            _lSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // bind to any interface, on port 1666
            try
            {
                _lSocket.Bind(new IPEndPoint(IPAddress.Any, 1666));
            }
            catch (Exception)
            {
                MessageBox.Show("There is maybe kinda a server already running on that port/address combo! ABORTING!");
                Application.Exit();
                return;
            }
            
            // start listening (does not fully accept connections at this point)
            _lSocket.Listen(5);
            // start the asynchronous accepting process (will wait if necessary)
            _lSocket.BeginAccept(cbAcceptDone, null);
        }

        private void cbAcceptDone (IAsyncResult ar)
        {
            try
            {
                _cSocket = _lSocket.EndAccept(ar);
                Invoke(new Action(() => Text = "Connected!"));
            }
            catch (Exception)
            {
                
            } 
        }
    }
}
