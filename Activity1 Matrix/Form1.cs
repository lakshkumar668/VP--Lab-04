using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1_Matrix
{
    public partial class Form1 : Form
    {
       Form2 obj2 = new Form2();
       public static int[] form1Data = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1Data[0] = Convert.ToInt32(textBox1.Text);
            form1Data[1] = Convert.ToInt32(textBox2.Text);
            form1Data[2] = Convert.ToInt32(textBox3.Text);
            form1Data[3] = Convert.ToInt32(textBox4.Text);
            form1Data[4] = Convert.ToInt32(textBox5.Text);
            form1Data[5] = Convert.ToInt32(textBox6.Text);

            Form1 obj1 = new Form1();
            obj1.Hide();

            obj2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
