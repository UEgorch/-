using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ПР14
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            

        }

        void Draw()
        {
            Graphics im = CreateGraphics();
            Brush brashGreen = new SolidBrush(Color.Green);
            Rectangle rect = new Rectangle(120, 100, 100, 190);
            im.FillRectangle(brashGreen, rect);

            Brush brashWhite = new SolidBrush(Color.White);
            Rectangle rectWhite = new Rectangle(222, 100, 100, 190);
            im.FillRectangle(brashWhite, rectWhite);

            Brush brashRed = new SolidBrush(Color.Red);
            Rectangle rectRed = new Rectangle(322, 100, 100, 190);
            im.FillRectangle(brashRed, rectRed);
        }

        void Gerb()
        {
            Graphics im = CreateGraphics();
            Image newImage = Image.FromFile("gerb.jpg");
            Bitmap bitmap = new Bitmap(newImage, 200, 200);
            im.DrawImage(bitmap, 100, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerb();
        }
    }
}
