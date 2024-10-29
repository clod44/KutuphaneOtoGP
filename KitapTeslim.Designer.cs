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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label1 = new Label();
            textBox_Email = new TextBox();
            textBox_Telefon = new TextBox();
            textBox_Soyad = new TextBox();
            textBox_Ad = new TextBox();
            textBox_TC = new TextBox();
            btn_uyeAra = new Button();
            listView_uyeler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            panel2 = new Panel();
            label2 = new Label();
            textBox_kitapDurum = new TextBox();
            textBox_kitapYayinevi = new TextBox();
            textBox_kitapDil = new TextBox();
            textBox_kitapBaskiYili = new TextBox();
            textBox_kitapYazar = new TextBox();
            textBox_kitapAd = new TextBox();
            textBox_kitapId = new TextBox();
            button_kitapAra = new Button();
            listView_kitaplar = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            tabPage3 = new TabPage();
            button_onayla = new Button();
            label_teslimGunu = new Label();
            dateTimePicker_teslimTarih = new DateTimePicker();
            dateTimePicker_bugun = new DateTimePicker();
            label_kitap = new Label();
            label_uye = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(906, 427);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(898, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "üye seç";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView_uyeler);
            splitContainer1.Size = new Size(892, 393);
            splitContainer1.SplitterDistance = 204;
            splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(textBox_Telefon);
            panel1.Controls.Add(textBox_Soyad);
            panel1.Controls.Add(textBox_Ad);
            panel1.Controls.Add(textBox_TC);
            panel1.Controls.Add(btn_uyeAra);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 389);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 318);
            label1.Name = "label1";
            label1.Size = new Size(200, 71);
            label1.TabIndex = 9;
            label1.Text = "en az 1 veri ile arama tuşuna basın ve yan taraftan üye seçin.  (DOUBLE CLICK)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Email
            // 
            textBox_Email.Dock = DockStyle.Top;
            textBox_Email.Location = new Point(0, 115);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.PlaceholderText = "Email";
            textBox_Email.Size = new Size(200, 23);
            textBox_Email.TabIndex = 5;
            textBox_Email.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Telefon
            // 
            textBox_Telefon.Dock = DockStyle.Top;
            textBox_Telefon.Location = new Point(0, 92);
            textBox_Telefon.Name = "textBox_Telefon";
            textBox_Telefon.PlaceholderText = "Telefon";
            textBox_Telefon.Size = new Size(200, 23);
            textBox_Telefon.TabIndex = 4;
            textBox_Telefon.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Soyad
            // 
            textBox_Soyad.Dock = DockStyle.Top;
            textBox_Soyad.Location = new Point(0, 69);
            textBox_Soyad.Name = "textBox_Soyad";
            textBox_Soyad.PlaceholderText = "Soyad";
            textBox_Soyad.Size = new Size(200, 23);
            textBox_Soyad.TabIndex = 3;
            textBox_Soyad.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_Ad
            // 
            textBox_Ad.Dock = DockStyle.Top;
            textBox_Ad.Location = new Point(0, 46);
            textBox_Ad.Name = "textBox_Ad";
            textBox_Ad.PlaceholderText = "Ad";
            textBox_Ad.Size = new Size(200, 23);
            textBox_Ad.TabIndex = 2;
            textBox_Ad.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_TC
            // 
            textBox_TC.Dock = DockStyle.Top;
            textBox_TC.Location = new Point(0, 23);
            textBox_TC.Name = "textBox_TC";
            textBox_TC.PlaceholderText = "TC";
            textBox_TC.Size = new Size(200, 23);
            textBox_TC.TabIndex = 1;
            textBox_TC.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_uyeAra
            // 
            btn_uyeAra.BackColor = Color.DeepSkyBlue;
            btn_uyeAra.Dock = DockStyle.Top;
            btn_uyeAra.Location = new Point(0, 0);
            btn_uyeAra.Name = "btn_uyeAra";
            btn_uyeAra.Size = new Size(200, 23);
            btn_uyeAra.TabIndex = 0;
            btn_uyeAra.Text = "Search";
            btn_uyeAra.UseVisualStyleBackColor = false;
            btn_uyeAra.Click += btn_uyeAra_Click;
            // 
            // listView_uyeler
            // 
            listView_uyeler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView_uyeler.Dock = DockStyle.Fill;
            listView_uyeler.FullRowSelect = true;
            listView_uyeler.GridLines = true;
            listView_uyeler.Location = new Point(0, 0);
            listView_uyeler.MultiSelect = false;
            listView_uyeler.Name = "listView_uyeler";
            listView_uyeler.Size = new Size(680, 389);
            listView_uyeler.TabIndex = 2;
            listView_uyeler.UseCompatibleStateImageBehavior = false;
            listView_uyeler.View = View.Details;
            listView_uyeler.DoubleClick += listView_uyeler_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TC";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Email";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Adres";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(898, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "kitap seç";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listView_kitaplar);
            splitContainer2.Size = new Size(892, 393);
            splitContainer2.SplitterDistance = 204;
            splitContainer2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_kitapDurum);
            panel2.Controls.Add(textBox_kitapYayinevi);
            panel2.Controls.Add(textBox_kitapDil);
            panel2.Controls.Add(textBox_kitapBaskiYili);
            panel2.Controls.Add(textBox_kitapYazar);
            panel2.Controls.Add(textBox_kitapAd);
            panel2.Controls.Add(textBox_kitapId);
            panel2.Controls.Add(button_kitapAra);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 389);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 318);
            label2.Name = "label2";
            label2.Size = new Size(200, 71);
            label2.TabIndex = 10;
            label2.Text = "en az 1 veri ile arama tuşuna basın ve yan taraftan kitap seçin. (DOUBLE CLICK)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_kitapDurum
            // 
            textBox_kitapDurum.Dock = DockStyle.Top;
            textBox_kitapDurum.Location = new Point(0, 161);
            textBox_kitapDurum.Name = "textBox_kitapDurum";
            textBox_kitapDurum.PlaceholderText = "Durum";
            textBox_kitapDurum.Size = new Size(200, 23);
            textBox_kitapDurum.TabIndex = 7;
            textBox_kitapDurum.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_kitapYayinevi
            // 
            textBox_kitapYayinevi.Dock = DockStyle.Top;
            textBox_kitapYayinevi.Location = new Point(0, 138);
            textBox_kitapYayinevi.Name = "textBox_kitapYayinevi";
            textBox_kitapYayinevi.PlaceholderText = "Yayın Evi";
            textBox_kitapYayinevi.Size = new Size(200, 23);
            textBox_kitapYayinevi.TabIndex = 6;
            textBox_kitapYayinevi.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_kitapDil
            // 
            textBox_kitapDil.Dock = DockStyle.Top;
            textBox_kitapDil.Location = new Point(0, 115);
            textBox_kitapDil.Name = "textBox_kitapDil";
            textBox_kitapDil.PlaceholderText = "Dil";
            textBox_kitapDil.Size = new Size(200, 23);
            textBox_kitapDil.TabIndex = 5;
            textBox_kitapDil.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_kitapBaskiYili
            // 
            textBox_kitapBaskiYili.Dock = DockStyle.Top;
            textBox_kitapBaskiYili.Location = new Point(0, 92);
            textBox_kitapBaskiYili.Name = "textBox_kitapBaskiYili";
            textBox_kitapBaskiYili.PlaceholderText = "Baskı Yılı";
            textBox_kitapBaskiYili.Size = new Size(200, 23);
            textBox_kitapBaskiYili.TabIndex = 4;
            textBox_kitapBaskiYili.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_kitapYazar
            // 
            textBox_kitapYazar.Dock = DockStyle.Top;
            textBox_kitapYazar.Location = new Point(0, 69);
            textBox_kitapYazar.Name = "textBox_kitapYazar";
            textBox_kitapYazar.PlaceholderText = "Yazar";
            textBox_kitapYazar.Size = new Size(200, 23);
            textBox_kitapYazar.TabIndex = 3;
            textBox_kitapYazar.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_kitapAd
            // 
            textBox_kitapAd.Dock = DockStyle.Top;
            textBox_kitapAd.Location = new Point(0, 46);
            textBox_kitapAd.Name = "textBox_kitapAd";
            textBox_kitapAd.PlaceholderText = "Ad";
            textBox_kitapAd.Size = new Size(200, 23);
            textBox_kitapAd.TabIndex = 2;
            textBox_kitapAd.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_kitapId
            // 
            textBox_kitapId.Dock = DockStyle.Top;
            textBox_kitapId.Location = new Point(0, 23);
            textBox_kitapId.Name = "textBox_kitapId";
            textBox_kitapId.PlaceholderText = "ID";
            textBox_kitapId.Size = new Size(200, 23);
            textBox_kitapId.TabIndex = 1;
            textBox_kitapId.TextAlign = HorizontalAlignment.Center;
            // 
            // button_kitapAra
            // 
            button_kitapAra.BackColor = Color.DeepSkyBlue;
            button_kitapAra.Dock = DockStyle.Top;
            button_kitapAra.Location = new Point(0, 0);
            button_kitapAra.Name = "button_kitapAra";
            button_kitapAra.Size = new Size(200, 23);
            button_kitapAra.TabIndex = 0;
            button_kitapAra.Text = "Search";
            button_kitapAra.UseVisualStyleBackColor = false;
            button_kitapAra.Click += button_kitapAra_Click;
            // 
            // listView_kitaplar
            // 
            listView_kitaplar.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            listView_kitaplar.Dock = DockStyle.Fill;
            listView_kitaplar.FullRowSelect = true;
            listView_kitaplar.GridLines = true;
            listView_kitaplar.Location = new Point(0, 0);
            listView_kitaplar.MultiSelect = false;
            listView_kitaplar.Name = "listView_kitaplar";
            listView_kitaplar.Size = new Size(680, 389);
            listView_kitaplar.TabIndex = 2;
            listView_kitaplar.UseCompatibleStateImageBehavior = false;
            listView_kitaplar.View = View.Details;
            listView_kitaplar.DoubleClick += listView_kitaplar_DoubleClick;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "id";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ad";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "yazar";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "baskı yılı";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "dil";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "yayınevi";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "durum";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button_onayla);
            tabPage3.Controls.Add(label_teslimGunu);
            tabPage3.Controls.Add(dateTimePicker_teslimTarih);
            tabPage3.Controls.Add(dateTimePicker_bugun);
            tabPage3.Controls.Add(label_kitap);
            tabPage3.Controls.Add(label_uye);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(898, 399);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tamamla";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_onayla
            // 
            button_onayla.Location = new Point(22, 158);
            button_onayla.Name = "button_onayla";
            button_onayla.Size = new Size(196, 35);
            button_onayla.TabIndex = 5;
            button_onayla.Text = "Onayla";
            button_onayla.UseVisualStyleBackColor = true;
            // 
            // label_teslimGunu
            // 
            label_teslimGunu.AutoSize = true;
            label_teslimGunu.Location = new Point(93, 101);
            label_teslimGunu.Name = "label_teslimGunu";
            label_teslimGunu.Size = new Size(37, 15);
            label_teslimGunu.TabIndex = 4;
            label_teslimGunu.Text = "0 gün";
            // 
            // dateTimePicker_teslimTarih
            // 
            dateTimePicker_teslimTarih.Location = new Point(18, 119);
            dateTimePicker_teslimTarih.Name = "dateTimePicker_teslimTarih";
            dateTimePicker_teslimTarih.ShowUpDown = true;
            dateTimePicker_teslimTarih.Size = new Size(200, 23);
            dateTimePicker_teslimTarih.TabIndex = 3;
            dateTimePicker_teslimTarih.ValueChanged += dateTimePicker_teslimTarih_ValueChanged;
            // 
            // dateTimePicker_bugun
            // 
            dateTimePicker_bugun.Enabled = false;
            dateTimePicker_bugun.Location = new Point(18, 71);
            dateTimePicker_bugun.Name = "dateTimePicker_bugun";
            dateTimePicker_bugun.Size = new Size(200, 23);
            dateTimePicker_bugun.TabIndex = 2;
            // 
            // label_kitap
            // 
            label_kitap.AutoSize = true;
            label_kitap.Location = new Point(18, 42);
            label_kitap.Name = "label_kitap";
            label_kitap.Size = new Size(147, 15);
            label_kitap.TabIndex = 1;
            label_kitap.Text = "seçili kitap: kitap seçilmedi";
            // 
            // label_uye
            // 
            label_uye.AutoSize = true;
            label_uye.Location = new Point(18, 18);
            label_uye.Name = "label_uye";
            label_uye.Size = new Size(133, 15);
            label_uye.TabIndex = 0;
            label_uye.Text = "seçili üye: üye seçilmedi";
            // 
            // KitapTeslim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(906, 427);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KitapTeslim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += KitapTeslim_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView listView_uyeler;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private TextBox textBox_TC;
        private Button btn_uyeAra;
        private TextBox textBox_Email;
        private TextBox textBox_Telefon;
        private TextBox textBox_Soyad;
        private TextBox textBox_Ad;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private SplitContainer splitContainer2;
        private Panel panel2;
        private TextBox textBox_kitapDil;
        private TextBox textBox_kitapBaskiYili;
        private TextBox textBox_kitapYazar;
        private TextBox textBox_kitapAd;
        private TextBox textBox_kitapId;
        private Button button_kitapAra;
        private ListView listView_kitaplar;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TextBox textBox_kitapYayinevi;
        private TextBox textBox_kitapDurum;
        private ColumnHeader columnHeader13;
        private Label label1;
        private Label label2;
        private Label label_uye;
        private Button button_onayla;
        private Label label_teslimGunu;
        private DateTimePicker dateTimePicker_teslimTarih;
        private DateTimePicker dateTimePicker_bugun;
        private Label label_kitap;
    }
}