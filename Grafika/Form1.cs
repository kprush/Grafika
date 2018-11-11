using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class Form1 : Form
    {
        bool rys;
        Graphics g;
        Pen p = new Pen(Color.Black, 2);
        Pen blue = new Pen(Color.Blue, 2);
        Pen black = new Pen(Color.Black, 2);
        Pen red = new Pen(Color.Red, 2);
        Pen gray = new Pen(Color.Gray, 2);
        Pen crimson = new Pen(Color.Crimson, 2);
        Pen orange = new Pen(Color.Orange, 2);
        Pen yellow = new Pen(Color.Yellow, 2);
        Pen lightblue = new Pen(Color.LightBlue, 2);
        Pen purple = new Pen(Color.Purple, 2);
        int x0, y0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Crimson;
            panel4.BackColor = Color.Red;
            panel5.BackColor = Color.Orange;
            panel6.BackColor = Color.Yellow;
            panel7.BackColor = Color.Green;
            panel8.BackColor = Color.Blue;
            panel9.BackColor = Color.Purple;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rys = true;
            x0 = e.X;
            y0 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            rys = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Black, 2);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Gray, 2);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Crimson, 2);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Red, 2);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Orange, 2);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Yellow, 2);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Green, 2);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Blue, 2);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.Purple, 2);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(rys)
            {
                int x = e.X; int y = e.Y;
                g.DrawLine(p, x0, y0, x, y);
                x0 = x;y0 = y;
            }
        }
    }
}
