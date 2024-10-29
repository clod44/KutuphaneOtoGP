namespace KutuphaneOtoGP
{
    partial class UyeListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeListele));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            listView1 = new ListView();
            columnHeaderTC = new ColumnHeader();
            columnHeaderAd = new ColumnHeader();
            columnHeaderSoyad = new ColumnHeader();
            columnHeaderTelNo = new ColumnHeader();
            columnHeaderMail = new ColumnHeader();
            columnHeaderAdres = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(825, 280);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(57, 35);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "TC No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 7);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 3;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 7);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 7);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Tel No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 7);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 3;
            label5.Text = "Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 7);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 3;
            label6.Text = "Adres";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(10, 286);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(60, 28);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderTC, columnHeaderAd, columnHeaderSoyad, columnHeaderTelNo, columnHeaderMail, columnHeaderAdres });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 25);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(872, 250);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeaderTC
            // 
            columnHeaderTC.Tag = "TC";
            columnHeaderTC.Text = "TC";
            // 
            // columnHeaderAd
            // 
            columnHeaderAd.Text = "Ad";
            // 
            // columnHeaderSoyad
            // 
            columnHeaderSoyad.Text = "Soyad";
            // 
            // columnHeaderTelNo
            // 
            columnHeaderTelNo.Text = "Tel No";
            // 
            // columnHeaderMail
            // 
            columnHeaderMail.Text = "Mail";
            // 
            // columnHeaderAdres
            // 
            columnHeaderAdres.Text = "Adres";
            // 
            // UyeListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(892, 324);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UyeListele";
            Text = "UyeListele";
            Load += UyeListele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeaderTC;
        private ColumnHeader columnHeaderAd;
        private ColumnHeader columnHeaderSoyad;
        private ColumnHeader columnHeaderTelNo;
        private ColumnHeader columnHeaderMail;
        private ColumnHeader columnHeaderAdres;
    }
}