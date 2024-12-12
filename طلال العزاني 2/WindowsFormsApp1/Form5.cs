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
    
    public partial class Form5 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Form5()
        {
            InitializeComponent();
            Combo.Items.Add("+");
            Combo.Items.Add("-");
            Combo.Items.Add("*");
            Combo.Items.Add("/");
            Combo.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtn3.ReadOnly = true;
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(txtn1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("تحذير","العدد الاول غير صالح",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtn1.Text = "";
                txtn1.Focus();
                return;
            }
            try
            {
                y = Convert.ToDouble(txtn2.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("تحذير", "العدد الثاني غير صالح",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtn2.Text = "";
                txtn2.Focus();
                return;

            }
            bool f = true;
            switch (Combo.SelectedIndex)
            {
                default: break;
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y; break;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر");
                        f = false;
                        txtn3.Text = null;
                        break;
                    }
                    
            }
            if (f)
            {
                txtn3.Text = z.ToString();
            }
        }
    }
}
