﻿namespace KutuphaneOtoGP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            nameTXT = new TextBox();
            passTXT = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 36);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // nameTXT
            // 
            nameTXT.Location = new Point(99, 12);
            nameTXT.Margin = new Padding(3, 2, 3, 2);
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(143, 23);
            nameTXT.TabIndex = 1;
            // 
            // passTXT
            // 
            passTXT.Location = new Point(99, 37);
            passTXT.Margin = new Padding(3, 2, 3, 2);
            passTXT.Name = "passTXT";
            passTXT.Size = new Size(143, 23);
            passTXT.TabIndex = 1;
            passTXT.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(155, 84);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 42);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(254, 142);
            Controls.Add(button1);
            Controls.Add(passTXT);
            Controls.Add(nameTXT);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTXT;
        private TextBox passTXT;
        private Button button1;
    }
}