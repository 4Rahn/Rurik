using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARDIP_Alfa
{
    public partial class Form1 : Form
    {
        int draw;
        string save;

        Graphics figure;
        Point click;
        Bitmap Layer1;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            draw = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog1 = new OpenFileDialog();
            dialog1.Filter = "image Filter(*.BMP;*.JPG;*.PNG;*GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";

            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog1.FileName);
                    
                    textBox1.Text = dialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog2 = new SaveFileDialog();
            dialog2.Title = "Сохранить картинку как...";
            dialog2.OverwritePrompt = true; //Перезаписать файл?
            dialog2.CheckPathExists = true; //Путь не существует
            dialog2.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|Image Files(*GIF)|*.GIF|All files (*.*)|*.*";
            dialog2.ShowHelp = true;   //Справка 

            if (dialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //pictureBox1.Image.Save(dialog2.FileName);
                    textBox2.Text = dialog2.FileName;
                    save = dialog2.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(save);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            figure = CreateGraphics();
            //List<Point> points = new List<Point>();
            //points.Add(new Point(...);
           // Bitmap layer1 = New Bitmap();

            if (draw == 1) //прямоугольник
            {

            }

            if (draw == 2) //многоугольник
            {

            }

            if (draw == 3) //эллипс
            {
                {
                    int v = 0;
                    Point point_position1 = new Point(0,0); Point point_position2 = new Point(0, 0);
                    if (v == 0)
                    {
                        point_position1 = click;
                        v++;
                    }
                    else if (v == 1)
                    {
                        point_position2 = click;
                        v++;
                    }
                    else
                    { 
                        figure.FillEllipse(Brushes.Black, point_position1.X, point_position1.Y, point_position2.X, point_position2.Y);
                        v = 0;
                    }
                }

                   
            }
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void tby_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Pen blackPen = new Pen(Color.Black, 1);

            // Рисовать так: 
            //Graphics g = Graphics.FromImage(pictureBox1.Image);

            //g.DrawLine(blackPen, 100,100,  600,100);

            //blackPen.Dispose();
            //g.Dispose();

            //pictureBox1.Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
