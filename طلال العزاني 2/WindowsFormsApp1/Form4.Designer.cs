namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "الناتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "العدد الثاني";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "العدد الاول";
            // 
            // txtn3
            // 
            this.txtn3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtn3.Location = new System.Drawing.Point(79, 105);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(105, 27);
            this.txtn3.TabIndex = 16;
            this.txtn3.TextChanged += new System.EventHandler(this.txtn3_TextChanged);
            // 
            // txtn2
            // 
            this.txtn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtn2.Location = new System.Drawing.Point(270, 105);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(175, 27);
            this.txtn2.TabIndex = 15;
            this.txtn2.TextChanged += new System.EventHandler(this.Text2_TextChanged);
            this.txtn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text2_KeyPress);
            // 
            // txtn1
            // 
            this.txtn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtn1.Location = new System.Drawing.Point(502, 105);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(175, 27);
            this.txtn1.TabIndex = 14;
            this.txtn1.TextChanged += new System.EventHandler(this.Text1_TextChanged);
            this.txtn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "=";
            // 
            // btnmul
            // 
            this.btnmul.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmul.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.ForeColor = System.Drawing.Color.Red;
            this.btnmul.Location = new System.Drawing.Point(239, 224);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(124, 42);
            this.btnmul.TabIndex = 24;
            this.btnmul.Text = "ضرب";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndiv.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.Color.Red;
            this.btndiv.Location = new System.Drawing.Point(79, 224);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(124, 42);
            this.btndiv.TabIndex = 23;
            this.btndiv.Text = "قسمة";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsub.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.ForeColor = System.Drawing.Color.Red;
            this.btnsub.Location = new System.Drawing.Point(399, 224);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(124, 42);
            this.btnsub.TabIndex = 22;
            this.btnsub.Text = "طرح";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Red;
            this.btnadd.Location = new System.Drawing.Point(553, 224);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 42);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "جمع";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(538, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 45);
            this.button5.TabIndex = 25;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(79, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 45);
            this.button6.TabIndex = 26;
            this.button6.Text = "إغلاق";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 379);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}