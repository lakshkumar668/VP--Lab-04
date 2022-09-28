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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Form2.Result[0].ToString();
            label2.Text = Form2.Result[1].ToString();
            label3.Text = Form2.Result[2].ToString();
            label4.Text = Form2.Result[3].ToString();
            label5.Text = Form2.Result[4].ToString();
            label6.Text = Form2.Result[5].ToString();

        }
    }
}
