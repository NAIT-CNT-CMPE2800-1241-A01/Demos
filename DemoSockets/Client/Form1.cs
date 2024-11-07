using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;


namespace Client
{
    public partial class Form1 : Form
    {
        private Socket _cSocket = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UI_B_Connect_Click(object sender, EventArgs e)
        {
            if (_cSocket != null)
            {
                // ahhhhh i'm using it already
                return;
            }
            
            _cSocket = new Socket(
                AddressFamily.InterNetwork, // IP V4 address scheme
                SocketType.Stream, // streaming socket (connection-based)
                ProtocolType.Tcp);

            _cSocket.BeginConnect(UI_TB_Address.Text.Trim(), 1666, CB_ConnectDone, null);
        }
        private void CB_ConnectDone (IAsyncResult ar)
        {
            try
            {
                _cSocket.EndConnect(ar);
                try
                {
                    Invoke(new Action(() => BackColor = Color.LightCyan));
                }
                catch (Exception)
                {
                    // log
                }                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);

                try
                {
                    Invoke(new Action(() => BackColor = Color.LightSalmon));
                }
                catch (Exception)
                {
                    // log
                }
            }
        }
    }
}
