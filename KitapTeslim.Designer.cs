namespace KutuphaneOtoGP
{
    partial class KitapTeslim
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            adTXT = new TextBox();
            soyadTXT = new TextBox();
            telTXT = new TextBox();
            kitapara = new TextBox();
            yazarTXT = new TextBox();
            dilTXT = new TextBox();
            groupBox1 = new GroupBox();
            ara = new TextBox();
            label11 = new Label();
            tcTXT = new TextBox();
            groupBox2 = new GroupBox();
            label14 = new Label();
            btngun = new Button();
            label10 = new Label();
            iadeTXT = new DateTimePicker();
            TeslimTXT = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            gunlbl = new TextBox();
            label12 = new Label();
            label13 = new Label();
            IDtxt = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "TC ile Ara:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 117);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Üye Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 149);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Üye Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 181);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefon No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 33);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 0;
            label5.Text = "Kitap Adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 65);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Yazar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 97);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 0;
            label7.Text = "Dil:";
            // 
            // adTXT
            // 
            adTXT.Enabled = false;
            adTXT.Location = new Point(130, 114);
            adTXT.Name = "adTXT";
            adTXT.Size = new Size(157, 27);
            adTXT.TabIndex = 1;
            // 
            // soyadTXT
            // 
            soyadTXT.Enabled = false;
            soyadTXT.Location = new Point(130, 146);
            soyadTXT.Name = "soyadTXT";
            soyadTXT.Size = new Size(157, 27);
            soyadTXT.TabIndex = 1;
            // 
            // telTXT
            // 
            telTXT.Enabled = false;
            telTXT.Location = new Point(130, 178);
            telTXT.Name = "telTXT";
            telTXT.Size = new Size(157, 27);
            telTXT.TabIndex = 1;
            // 
            // kitapara
            // 
            kitapara.Location = new Point(119, 30);
            kitapara.Name = "kitapara";
            kitapara.Size = new Size(174, 27);
            kitapara.TabIndex = 2;
            kitapara.TextChanged += kitapara_TextChanged;
            // 
            // yazarTXT
            // 
            yazarTXT.Enabled = false;
            yazarTXT.Location = new Point(119, 62);
            yazarTXT.Name = "yazarTXT";
            yazarTXT.Size = new Size(174, 27);
            yazarTXT.TabIndex = 1;
            // 
            // dilTXT
            // 
            dilTXT.Enabled = false;
            dilTXT.Location = new Point(119, 95);
            dilTXT.Name = "dilTXT";
            dilTXT.Size = new Size(174, 27);
            dilTXT.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ara);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(telTXT);
            groupBox1.Controls.Add(soyadTXT);
            groupBox1.Controls.Add(tcTXT);
            groupBox1.Controls.Add(adTXT);
            groupBox1.Location = new Point(26, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 217);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye Bilgileri";
            // 
            // ara
            // 
            ara.Location = new Point(130, 24);
            ara.Name = "ara";
            ara.Size = new Size(157, 27);
            ara.TabIndex = 1;
            ara.TextChanged += ara_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 84);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 0;
            label11.Text = "Üye TC:";
            // 
            // tcTXT
            // 
            tcTXT.Enabled = false;
            tcTXT.Location = new Point(130, 81);
            tcTXT.Name = "tcTXT";
            tcTXT.Size = new Size(157, 27);
            tcTXT.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(btngun);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(iadeTXT);
            groupBox2.Controls.Add(TeslimTXT);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(gunlbl);
            groupBox2.Controls.Add(dilTXT);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(yazarTXT);
            groupBox2.Controls.Add(kitapara);
            groupBox2.Location = new Point(340, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 250);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Bilgileri";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(351, 62);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 6;
            label14.Text = "Durum";
            // 
            // btngun
            // 
            btngun.Location = new Point(367, 175);
            btngun.Name = "btngun";
            btngun.Size = new Size(65, 53);
            btngun.TabIndex = 5;
            btngun.Text = "Gün hesabı";
            btngun.UseVisualStyleBackColor = true;
            btngun.Click += btngun_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(351, 23);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 4;
            label10.Text = "Kitap ID";
            // 
            // iadeTXT
            // 
            iadeTXT.Location = new Point(119, 204);
            iadeTXT.Name = "iadeTXT";
            iadeTXT.Size = new Size(228, 27);
            iadeTXT.TabIndex = 3;
            // 
            // TeslimTXT
            // 
            TeslimTXT.Location = new Point(119, 167);
            TeslimTXT.Name = "TeslimTXT";
            TeslimTXT.Size = new Size(228, 27);
            TeslimTXT.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 209);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 2;
            label9.Text = "İade Günü:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 172);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 2;
            label8.Text = "Teslim günü:";
            // 
            // gunlbl
            // 
            gunlbl.Enabled = false;
            gunlbl.Location = new Point(119, 127);
            gunlbl.Name = "gunlbl";
            gunlbl.ReadOnly = true;
            gunlbl.Size = new Size(174, 27);
            gunlbl.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 129);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 0;
            label12.Text = "Gün:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(77, 22);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 5;
            label13.Text = "ID:";
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(156, 19);
            IDtxt.Name = "IDtxt";
            IDtxt.ReadOnly = true;
            IDtxt.Size = new Size(157, 27);
            IDtxt.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.agreement;
            pictureBox1.Location = new Point(722, 277);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // KitapTeslim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(797, 342);
            Controls.Add(pictureBox1);
            Controls.Add(IDtxt);
            Controls.Add(label13);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "KitapTeslim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += KitapTeslim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label7;
        private TextBox adTXT;
        private TextBox soyadTXT;
        private TextBox telTXT;
        private TextBox kitapara;
        private TextBox yazarTXT;
        private TextBox dilTXT;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker iadeTXT;
        private DateTimePicker TeslimTXT;
        private Label label9;
        private Label label8;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
        private TextBox tcTXT;
        private MaskedTextBox maskedTextBox1;
        private TextBox ara;
        private TextBox gunlbl;
        private Label label12;
        private Button btngun;
        private Label label13;
        private TextBox IDtxt;
        private Label label14;
        private PictureBox pictureBox1;
    }
}