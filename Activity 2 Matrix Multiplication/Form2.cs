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
    public partial class Form2 : Form
    {
        Form3 obj3 = new Form3();
        int[] formData2 = new int[6];
        public static int[] Result = new int[6];
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formData2[0] = Convert.ToInt32(textBox1.Text);
           // formData2[1] = Convert.ToInt32(textBox2.Text);
            formData2[1] = Convert.ToInt32(textBox3.Text);
            formData2[2] = Convert.ToInt32(textBox4.Text);
            //formData2[4] = Convert.ToInt32(textBox5.Text);
            formData2[3] = Convert.ToInt32(textBox6.Text);

            Result[0] = Form1.formData1[0] * formData2[0] + Form1.formData1[1] * formData2[2];
            Result[1] = Form1.formData1[0] * formData2[1] + Form1.formData1[1] * formData2[3];
            Result[2] = Form1.formData1[2] * formData2[0] + Form1.formData1[3] * formData2[2];
            Result[3] = Form1.formData1[2] * formData2[1] + Form1.formData1[3] * formData2[3];

            Form2 obj2 = new Form2();
            obj2.Hide();
            obj3.ShowDialog();
        }
    }
}
