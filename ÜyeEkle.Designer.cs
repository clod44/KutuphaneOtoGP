namespace KutuphaneOtoGP
{
    partial class UyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            txtTC = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAdres = new TextBox();
            txtTel = new MaskedTextBox();
            Kaydet = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTC
            // 
            txtTC.Location = new Point(110, 12);
            txtTC.Margin = new Padding(3, 2, 3, 2);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(124, 23);
            txtTC.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(110, 38);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(124, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(110, 64);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(124, 23);
            txtSoyad.TabIndex = 0;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(110, 117);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(124, 23);
            txtMail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 67);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 93);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 1;
            label4.Text = "Telefon No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 119);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 1;
            label5.Text = "E-Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 146);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 2;
            label6.Text = "Adres:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(110, 146);
            txtAdres.Margin = new Padding(3, 2, 3, 2);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(202, 88);
            txtAdres.TabIndex = 3;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(110, 91);
            txtTel.Margin = new Padding(3, 2, 3, 2);
            txtTel.Mask = "00000000000000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(124, 23);
            txtTel.TabIndex = 4;
            // 
            // Kaydet
            // 
            Kaydet.FlatStyle = FlatStyle.Flat;
            Kaydet.Image = (Image)resources.GetObject("Kaydet.Image");
            Kaydet.Location = new Point(265, 237);
            Kaydet.Margin = new Padding(3, 2, 3, 2);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(46, 45);
            Kaydet.TabIndex = 5;
            Kaydet.UseVisualStyleBackColor = true;
            Kaydet.Click += Kaydet_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(10, 255);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(51, 27);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(318, 291);
            Controls.Add(button1);
            Controls.Add(Kaydet);
            Controls.Add(txtTel);
            Controls.Add(txtAdres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtTC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UyeEkle";
            Text = "ÜyeEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTC;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAdres;
        private MaskedTextBox txtTel;
        private Button Kaydet;
        private Button button1;
    }
}