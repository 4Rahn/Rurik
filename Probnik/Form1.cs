using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Probnik
{
    public partial class Form1 : Form
    {
        public static Bitmap CombineBitmap(IEnumerable<string> files)
        {
            //read all images into memory
            List<Bitmap> images = new List<Bitmap>();
            Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in files)
                {
                    // create a Bitmap from the file and add it to the list
                    Bitmap bitmap = new Bitmap(image);

                    // update the size of the final bitmap
                    width += bitmap.Width;
                    height = bitmap.Height > height ? bitmap.Height : height;

                    images.Add(bitmap);
                }

                // create a bitmap to hold the combined image
                finalImage = new Bitmap(width, height);

                // get a graphics object from the image so we can draw on it
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    // set background color
                    g.Clear(Color.Transparent);

                    // go through each image and draw it on the final image
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
                    }
                }

                return finalImage;
            }
            catch (Exception)
            {
                if (finalImage != null) finalImage.Dispose();
                throw;
            }
            finally
            {
                // clean up memory
                foreach (Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            dialog1.Filter = "image Filter(*.BMP;*.JPG;*.PNG;*GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";

            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog1.FileName);
                    var dn = Path.GetFileName(Path.GetDirectoryName(dialog1.FileName));
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = CombineBitmap(new[] { @"a:\1.png", @"a:\2.png" });

            // загружаем результат в PictureBox
            pictureBox1.Image = bitmap;

            // сохраняем в файл
            bitmap.Save(@"a:\3.png");
        }
    }
}
