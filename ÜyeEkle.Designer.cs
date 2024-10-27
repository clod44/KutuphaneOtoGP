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
            txtTC.Location = new Point(126, 16);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(141, 27);
            txtTC.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(126, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(141, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(126, 86);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(141, 27);
            txtSoyad.TabIndex = 0;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(126, 156);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(141, 27);
            txtMail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 1;
            label4.Text = "Telefon No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 1;
            label5.Text = "E-Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 194);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 2;
            label6.Text = "Adres:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(126, 194);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(230, 116);
            txtAdres.TabIndex = 3;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(126, 121);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(141, 27);
            txtTel.TabIndex = 4;
            // 
            // Kaydet
            // 
            Kaydet.FlatStyle = FlatStyle.Flat;
            Kaydet.Image = (Image)resources.GetObject("Kaydet.Image");
            Kaydet.Location = new Point(303, 316);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(53, 60);
            Kaydet.TabIndex = 5;
            Kaydet.UseVisualStyleBackColor = true;
            Kaydet.Click += Kaydet_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 340);
            button1.Name = "button1";
            button1.Size = new Size(58, 36);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(363, 388);
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