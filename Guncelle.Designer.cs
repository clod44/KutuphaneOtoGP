namespace KutuphaneOtoGP
{
    partial class Guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guncelle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tcTXT = new TextBox();
            adTXT = new TextBox();
            soyadTXT = new TextBox();
            telTXT = new TextBox();
            mailTXT = new TextBox();
            adresTXT = new TextBox();
            kaydet = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "TC No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Tel No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 146);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 0;
            label5.Text = "E-Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 177);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Adres";
            // 
            // tcTXT
            // 
            tcTXT.Location = new Point(106, 17);
            tcTXT.Name = "tcTXT";
            tcTXT.Size = new Size(177, 27);
            tcTXT.TabIndex = 1;
            // 
            // adTXT
            // 
            adTXT.Location = new Point(106, 49);
            adTXT.Name = "adTXT";
            adTXT.Size = new Size(177, 27);
            adTXT.TabIndex = 1;
            // 
            // soyadTXT
            // 
            soyadTXT.Location = new Point(106, 81);
            soyadTXT.Name = "soyadTXT";
            soyadTXT.Size = new Size(177, 27);
            soyadTXT.TabIndex = 1;
            // 
            // telTXT
            // 
            telTXT.Location = new Point(106, 112);
            telTXT.Name = "telTXT";
            telTXT.Size = new Size(177, 27);
            telTXT.TabIndex = 1;
            // 
            // mailTXT
            // 
            mailTXT.Location = new Point(106, 143);
            mailTXT.Name = "mailTXT";
            mailTXT.Size = new Size(177, 27);
            mailTXT.TabIndex = 1;
            // 
            // adresTXT
            // 
            adresTXT.Location = new Point(106, 174);
            adresTXT.Name = "adresTXT";
            adresTXT.Size = new Size(177, 27);
            adresTXT.TabIndex = 1;
            // 
            // kaydet
            // 
            kaydet.FlatStyle = FlatStyle.Flat;
            kaydet.Image = (Image)resources.GetObject("kaydet.Image");
            kaydet.Location = new Point(231, 207);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(52, 54);
            kaydet.TabIndex = 2;
            kaydet.UseVisualStyleBackColor = true;
            kaydet.Click += kaydet_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 247);
            button1.Name = "button1";
            button1.Size = new Size(62, 35);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Guncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(300, 292);
            Controls.Add(button1);
            Controls.Add(kaydet);
            Controls.Add(adresTXT);
            Controls.Add(mailTXT);
            Controls.Add(telTXT);
            Controls.Add(soyadTXT);
            Controls.Add(adTXT);
            Controls.Add(tcTXT);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Guncelle";
            Text = "Guncelle";
            Load += Guncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tcTXT;
        private TextBox adTXT;
        private TextBox soyadTXT;
        private TextBox telTXT;
        private TextBox mailTXT;
        private TextBox adresTXT;
        private Button kaydet;
        private Button button1;
    }
}