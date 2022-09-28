using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2_Matrix_Multiplication
{
    public partial class Form1 : Form
    {
        Form2 obj2 = new Form2();
        public static int[] formData1 = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formData1[0] = Convert.ToInt32(textBox1.Text);
            //formData1[1] = Convert.ToInt32(textBox2.Text);
            formData1[1] = Convert.ToInt32(textBox3.Text);
            formData1[2] = Convert.ToInt32(textBox4.Text);
           // formData1[4] = Convert.ToInt32(textBox5.Text);
            formData1[3] = Convert.ToInt32(textBox6.Text);
            Form1 obj1 = new Form1();
            obj1.Hide();
            obj2.ShowDialog();
        }
    }
}
