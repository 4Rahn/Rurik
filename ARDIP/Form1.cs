using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ARDIP
{
    public partial class Form1 : Form
    {
        int draw;
        string save;

        int Cursor1X = Cursor.Position.X;
        int Cursor2Y = Cursor.Position.Y;
        

                    public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(save);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            dialog1.Filter = "image Filter(*.BMP;*.JPG;*.PNG;*GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";

            if(dialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog1.FileName);
                    textBox2.Text = dialog1.FileName;
                }
                catch 
                { 
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

            {
                

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void draw_s_Click(object sender, EventArgs e)
        {
            draw = 1;
        }

        private void draw_p_Click(object sender, EventArgs e)
        {
            draw = 2;
        }

        private void draw_c_Click(object sender, EventArgs e)
        {
            draw = 3;
        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (draw == 1)
            {

            }

            if (draw == 2)
            {

            }

            if (draw == 3) 
            { 
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
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
                        textBox1.Text = dialog2.FileName;
                        save = dialog2.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void CursorX_TextChanged(object sender, EventArgs e)
        {
            CursorX.Text = Cursor1X.ToString();
        }

        private void CursorY_TextChanged(object sender, EventArgs e)
        {
            CursorY.Text = Cursor2Y.ToString();
        }
    }
}
