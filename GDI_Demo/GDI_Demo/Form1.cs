using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();

            for (int iy = 0; iy < Height; iy += 5)
                gr.DrawLine(new Pen(Color.Red, 1), 0, iy, iy, Height);
        }
    }
}
