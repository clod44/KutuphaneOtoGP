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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 10);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 10);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 10);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 2;
            label4.Text = "Yıl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 10);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 2;
            label5.Text = "Sayfa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 10);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 2;
            label6.Text = "Dil";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 10);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 2;
            label7.Text = "Yayın Evi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(434, 10);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 2;
            label8.Text = "Durum";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 10);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 2;
            label9.Text = "Konu";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(10, 309);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(54, 28);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 28);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(747, 255);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Yazar";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Yıl";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Sayfa";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Dil";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "yayın evi";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "durum";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "konu";
            // 
            // KitapListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(780, 342);
            Controls.Add(listView1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "KitapListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KitapListele";
            Load += KitapListele_Load;
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
        private Label label8;
        private Label label9;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}