using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    
    public partial class Form1 : Form
    {
        Random random = new Random();
        int initialPic;
        int selectPic;
        int trials;
       public static string win, loss;

        Form2 obj = new Form2();
        Form3 obj1 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialPic = random.Next(1, 5);
            this.button17.Image = Image.FromFile("E:\\Pictures\\" + initialPic + ".jpg");
        }
        public void checkWinner()
        {
            if (initialPic == selectPic)
            {
                win = "You are winner";
                obj.ShowDialog();
            }
            else
            {
                trials++;
                if (trials == 3)
                {
                    loss = "YOU LOSS";
                    obj1.ShowDialog();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button1.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();

        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button2.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button3.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button4.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1,5);
            this.button5.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1,5);
            this.button6.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1,5);
            this.button7.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button8.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button9.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button10.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button11.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button12.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button13.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button14.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button15.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            selectPic = random.Next(1, 5);
            this.button16.Image = Image.FromFile("E:\\Pictures\\" + selectPic + ".jpg");
            checkWinner();
        }

        private void button16_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
