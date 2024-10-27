namespace KutuphaneOtoGP
{
    partial class KitapListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapListele));
            guncelle = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // guncelle
            // 
            guncelle.FlatStyle = FlatStyle.Flat;
            guncelle.Image = (Image)resources.GetObject("guncelle.Image");
            guncelle.Location = new Point(817, 402);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(63, 42);
            guncelle.TabIndex = 0;
            guncelle.UseVisualStyleBackColor = true;
            guncelle.Click += guncelle_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(868, 344);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 14);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 14);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Yazar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 14);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 2;
            label4.Text = "Yıl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 14);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 2;
            label5.Text = "Sayfa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 14);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 2;
            label6.Text = "Dil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 14);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 2;
            label7.Text = "Yayın Evi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(496, 14);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 2;
            label8.Text = "Durum";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(572, 14);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 2;
            label9.Text = "Konu";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 412);
            button1.Name = "button1";
            button1.Size = new Size(62, 37);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KitapListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(892, 456);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(guncelle);
            Name = "KitapListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KitapListele";
            Load += KitapListele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guncelle;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}