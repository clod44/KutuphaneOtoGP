namespace KutuphaneOtoGP
{
    partial class signin
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtUsername = new TextBox();
            txtMail = new TextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            txtPassw = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(288, 83);
            button1.Name = "button1";
            button1.Size = new Size(109, 56);
            button1.TabIndex = 0;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 101);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 1;
            label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 134);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 1;
            label4.Text = "E-Mail:";
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(146, 65);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(146, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(146, 131);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(146, 210);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(217, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Sözleşmeyi Kabul Ediyorum.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 167);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 1;
            label5.Text = "Şifre:";
            // 
            // txtPassw
            // 
            txtPassw.Location = new Point(146, 164);
            txtPassw.Name = "txtPassw";
            txtPassw.Size = new Size(125, 27);
            txtPassw.TabIndex = 2;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 259);
            Controls.Add(checkBox1);
            Controls.Add(txtPassw);
            Controls.Add(txtMail);
            Controls.Add(txtUsername);
            Controls.Add(txtSurname);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "signin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtUsername;
        private TextBox txtMail;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox txtPassw;
    }
}