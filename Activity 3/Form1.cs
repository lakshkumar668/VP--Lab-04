using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_3
{
    public partial class Form1 : Form
    {

        int currentImage = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // this.picSlideShow.ImageLocation = "E:\\Pictures\\1.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.picSlideShow.ImageLocation = "E:\\Pictures\\"+currentImage+".jpg";
            currentImage++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentImage--;
            this.picSlideShow.ImageLocation = "E:\\Pictures\\" + currentImage + ".jpg";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
