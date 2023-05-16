using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        private Point start;
        private bool drawing = false;
        public Form1()
        {
            InitializeComponent();
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            Paint += Form1_Paint;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            drawing = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                int width = e.ClipRectangle.Width;
                int height = e.ClipRectangle.Height;

                int left = Math.Min(start.X, Cursor.Position.X) - Location.X;
                int top = Math.Min(start.Y, Cursor.Position.Y) - Location.Y;
                int right = Math.Max(start.X, Cursor.Position.X) - Location.X;
                int bottom = Math.Max(start.Y, Cursor.Position.Y) - Location.Y;

                Rectangle rect = new Rectangle(left, top, right - left, bottom - top);
                e.Graphics.DrawEllipse(Pens.Black, rect);

                Text = string.Format("Width: {0} Height: {1}", right - left, bottom - top);
            }
        }
    }
}
