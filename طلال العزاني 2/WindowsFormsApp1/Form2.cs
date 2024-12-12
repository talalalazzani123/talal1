﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text !=""&&textBox2.Text!="")
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;

            }
            else
            {
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text=(Convert.ToDouble(textBox1.Text)+Convert.ToDouble(textBox2.Text)).ToString();
            textBox3.BackColor=Color.Red;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += textBox2_TextChanged;
            button1.Enabled = button2.Enabled = 
                button3.Enabled = button4.Enabled = false;
            textBox3.ReadOnly = true;
            this.Text = "الة حاسبة بسيطة";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
            textBox3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            textBox3.BackColor = Color.Red;
        }
    }
}
