﻿namespace HAFTA2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 49);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "AD SOYAD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(574, 190);
            button1.Name = "button1";
            button1.Size = new Size(122, 69);
            button1.TabIndex = 2;
            button1.Text = "PERSONEL OLUŞTUR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(231, 339);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 249);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "YAŞ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 153);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "ADRES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 342);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "ÜNVAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 439);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 7;
            label5.Text = "MESAİ SAATİ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 153);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 41);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 436);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 27);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 508);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}