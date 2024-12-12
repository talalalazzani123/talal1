using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            txtn3.BackColor = Color.Red;

            enabeld(false);
        }
        public void isnumber(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) 
            {
                e.Handled = true;
            }
        }
        public void enabeld(bool f)
        {
            btndiv.Enabled = f;
            btnmul.Enabled = f;
            btnsub.Enabled = f;
            btnadd.Enabled = f;

        }
        public void operation(double n1,double n2,string op)
        {
            switch(op)
            {
                case "+":
                    txtn3.Text=(n1+n2).ToString(); 
                    break;
                case "-":txtn3.Text = (n1 - n2).ToString();
                    break;
                case "*": txtn3.Text = (n1 * n2).ToString();
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        txtn3.Text = (n1 / n2).ToString();
                    }
                    else
                        MessageBox.Show("تحذير", "لايمكن القسمة على صفر",
                            MessageBoxButtons.YesNoCancel, 
                            MessageBoxIcon.Warning, 
                            MessageBoxDefaultButton.Button3);
                    break;
                default:
                    txtn3.BackColor = Color.Black;
                    MessageBox.Show("تحذير العملية المدخلة", "غلط",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button3);
                    break;

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtn2.TextChanged += Text1_TextChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txtn1.Text), double.Parse(txtn2.Text), "-");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txtn1.Text), double.Parse(txtn2.Text), "*");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txtn1.Text), double.Parse(txtn2.Text),"/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txtn1.Text),double.Parse(txtn2.Text),"+");
        }

        private void Text1_TextChanged(object sender, EventArgs e)
        {
            bool f = (txtn1.Text.Trim() != "" && txtn2.Text.Trim() != "");
            enabeld(f);
        }

        private void Text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            isnumber(e);
        }

        private void Text2_KeyPress(object sender, KeyPressEventArgs e)
        {
            isnumber(e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
        }

        private void txtn3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
