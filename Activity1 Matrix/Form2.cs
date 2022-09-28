using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1_Matrix
{
    
    public partial class Form2 : Form
    {
        int[] form2Data = new int[6];
        public static int[] Result = new int[6];
        
        Form3 obj3 = new Form3();
        public Form2()
        {
           
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
               
            form2Data[0] = Convert.ToInt32(textBox1.Text);
            form2Data[1] = Convert.ToInt32(textBox2.Text);
            form2Data[2] = Convert.ToInt32(textBox3.Text);
            form2Data[3] = Convert.ToInt32(textBox4.Text);
            form2Data[4] = Convert.ToInt32(textBox5.Text);
            form2Data[5] = Convert.ToInt32(textBox6.Text);
            
           
            for(int i=0; i<6; i++)
            {
                Result[i] = Form1.form1Data[i] + form2Data[i];
            }
            Form2 obj2 = new Form2();
            obj2.Hide();
            obj3.ShowDialog();
        }
    }
}
