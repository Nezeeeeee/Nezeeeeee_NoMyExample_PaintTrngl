using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTrngl
{
    public partial class Form1 : Form
    {
        int x, y, x2, y2;
        Graphics g;
        Pen p;
        byte state;

        public Form1()
        {
            
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Black);
            state = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (state)
            {
                case 0:
                    x = e.X;
                    y = e.Y;
                    state++;
                    break;
                case 1:
                    g.DrawLine(p, x, y, e.X, e.Y);
                    x2 = e.X;
                    y2 = e.Y;
                    state++;
                    break;
                case 2:
                    g.DrawLine(p, x, y, e.X, e.Y);
                    g.DrawLine(p, e.X, e.Y, x2, y2);
                    state = 0;
                    break;

            }
        }
    }
}
