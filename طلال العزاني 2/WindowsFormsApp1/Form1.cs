using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48||e.KeyChar>57)&&(e.KeyChar!=8)) e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) e.Handled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox1.Text!="")
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled=false;
            }




































        }

        private void textBox2_TextChanges(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void From1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("ادخل العدد الاول");
                textBox1.Focus();
                button1.Enabled = true;
                
            }
            else if(textBox2.Text.Trim()=="")
            {
                MessageBox.Show("ادخل العدد الثاني");
                textBox2.Focus();
                button1.Enabled=true;   

            }
            else
            {
                double x=Convert.ToDouble(textBox1.Text);
                double y=Convert.ToDouble(textBox2.Text);
                double z = x + y;
                textBox3.Text= z.ToString();
                textBox1.Text = textBox2.Text = "";
            }
        }

        private void textBox3_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
    }
}
