namespace KutuphaneOtoGP
{
    partial class Personeller
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            checkedListBox_yetkiler = new CheckedListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_kaydet = new Button();
            textBox_aciklama = new TextBox();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            label_warning = new Label();
            button_yeniHesap = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView_personeller = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(568, 335);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(560, 307);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "hesaplar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(560, 307);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "yetkiler";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_kaydet);
            panel1.Controls.Add(textBox_aciklama);
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(textBox_username);
            panel1.Controls.Add(label_warning);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 301);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox_yetkiler);
            groupBox1.Location = new Point(18, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 135);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // checkedListBox_yetkiler
            // 
            checkedListBox_yetkiler.Dock = DockStyle.Fill;
            checkedListBox_yetkiler.FormattingEnabled = true;
            checkedListBox_yetkiler.Items.AddRange(new object[] { "aktif hesap", "personel hesapları erişim", "üye hesapları erişim", "kitap (ekle sil düzenle)", "teslimat (ekle tamamla)" });
            checkedListBox_yetkiler.Location = new Point(3, 19);
            checkedListBox_yetkiler.Name = "checkedListBox_yetkiler";
            checkedListBox_yetkiler.Size = new Size(517, 113);
            checkedListBox_yetkiler.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 12;
            label3.Text = "açıklama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 10;
            label1.Text = "username";
            // 
            // button_kaydet
            // 
            button_kaydet.Location = new Point(474, 273);
            button_kaydet.Name = "button_kaydet";
            button_kaydet.Size = new Size(75, 23);
            button_kaydet.TabIndex = 9;
            button_kaydet.Text = "KAYDET";
            button_kaydet.UseVisualStyleBackColor = true;
            button_kaydet.Click += button_kaydet_Click;
            // 
            // textBox_aciklama
            // 
            textBox_aciklama.Location = new Point(86, 90);
            textBox_aciklama.Name = "textBox_aciklama";
            textBox_aciklama.Size = new Size(455, 23);
            textBox_aciklama.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(86, 61);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(196, 23);
            textBox_password.TabIndex = 2;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(86, 32);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(196, 23);
            textBox_username.TabIndex = 1;
            // 
            // label_warning
            // 
            label_warning.AutoSize = true;
            label_warning.Location = new Point(12, 9);
            label_warning.Name = "label_warning";
            label_warning.Size = new Size(289, 15);
            label_warning.TabIndex = 0;
            label_warning.Text = "hesaplar tabindan bir hesapa tıklayın (DOUBLE CLICK)";
            // 
            // button_yeniHesap
            // 
            button_yeniHesap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_yeniHesap.AutoSize = true;
            button_yeniHesap.Location = new Point(425, 3);
            button_yeniHesap.Name = "button_yeniHesap";
            button_yeniHesap.Size = new Size(126, 25);
            button_yeniHesap.TabIndex = 1;
            button_yeniHesap.Text = "Yeni Personel Hesabı";
            button_yeniHesap.UseVisualStyleBackColor = true;
            button_yeniHesap.Click += button_yeniHesap_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listView_personeller, 0, 1);
            tableLayoutPanel1.Controls.Add(button_yeniHesap, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(554, 301);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "username";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "açıklama";
            // 
            // listView_personeller
            // 
            listView_personeller.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView_personeller.Dock = DockStyle.Fill;
            listView_personeller.FullRowSelect = true;
            listView_personeller.GridLines = true;
            listView_personeller.Location = new Point(3, 34);
            listView_personeller.MultiSelect = false;
            listView_personeller.Name = "listView_personeller";
            listView_personeller.Size = new Size(548, 264);
            listView_personeller.TabIndex = 0;
            listView_personeller.UseCompatibleStateImageBehavior = false;
            listView_personeller.View = View.Details;
            listView_personeller.DoubleClick += listView_personeller_DoubleClick;
            // 
            // Personeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 335);
            Controls.Add(tabControl1);
            Name = "Personeller";
            Text = "Personeller";
            Load += Personeller_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox textBox_aciklama;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private Label label_warning;
        private CheckedListBox checkedListBox_yetkiler;
        private Label label1;
        private Button button_kaydet;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_yeniHesap;
        private ListView listView_personeller;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}