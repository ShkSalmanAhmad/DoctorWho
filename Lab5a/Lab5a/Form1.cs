using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Lab5a
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private SolidBrush b;
        private Color c = Color.Black;
        int CurrentValue;
        int PreviousValue;
        private Pen p;
        public Form1()
        {
            InitializeComponent();
            CurrentValue = 0;
            PreviousValue = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorsPallette.Color = c;
            ColorsPallette.ShowDialog();
            c = ColorsPallette.Color;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(c);
            b = new SolidBrush(c);

            g = this.CreateGraphics();

            g.DrawLine(p, 120, 250, 120, 400); //draw the left vertical line
            g.DrawLine(p, 120, 400, 300, 400); //draw the horizontal bottom line
            g.DrawLine(p, 300, 250, 300, 400); //draw the right vertical line
        }

        private void flowbar_Scroll(object sender, EventArgs e)
        {
            Invalidate();
            if (CurrentValue == 0)
            {
                CurrentValue = flowbar.Value;
            }
            else
            {
                PreviousValue = CurrentValue;
                CurrentValue = flowbar.Value;
            }
            for (double i = 400; i >= 250; i = i - (CurrentValue * 0.1))
            {
                g.FillRectangle(b, new Rectangle(143, Convert.ToInt32(150), 30, Convert.ToInt32(250)));
                g.FillRectangle(b, new Rectangle(120, Convert.ToInt32(i), 180, Convert.ToInt32(400 - i)));
                Thread.Sleep(1);
            }
            flowbar.Value = 0;
        }


    }
}
