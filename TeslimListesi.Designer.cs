namespace KutuphaneOtoGP
{
    partial class TeslimListesi
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
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            panel2 = new Panel();
            checkBox_teslimEdildi = new CheckBox();
            textBox_kitapID = new TextBox();
            textBox_TC = new TextBox();
            label2 = new Label();
            textBox_teslimId = new TextBox();
            button_teslimAra = new Button();
            listView_teslimatlar = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            tabPage3 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label_teslimdetay = new Label();
            dateTimePicker_odunc = new DateTimePicker();
            button_onayla = new Button();
            label_teslimGunFark = new Label();
            dateTimePicker_teslimEdilmesiGereken = new DateTimePicker();
            dateTimePicker_teslim = new DateTimePicker();
            tabControl1.SuspendLayout();
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
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(691, 380);
            tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(683, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "teslimatlar";
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
            splitContainer2.Panel2.Controls.Add(listView_teslimatlar);
            splitContainer2.Size = new Size(677, 346);
            splitContainer2.SplitterDistance = 154;
            splitContainer2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(checkBox_teslimEdildi);
            panel2.Controls.Add(textBox_kitapID);
            panel2.Controls.Add(textBox_TC);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_teslimId);
            panel2.Controls.Add(button_teslimAra);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 342);
            panel2.TabIndex = 0;
            // 
            // checkBox_teslimEdildi
            // 
            checkBox_teslimEdildi.AutoSize = true;
            checkBox_teslimEdildi.Dock = DockStyle.Top;
            checkBox_teslimEdildi.Location = new Point(0, 92);
            checkBox_teslimEdildi.Name = "checkBox_teslimEdildi";
            checkBox_teslimEdildi.Size = new Size(150, 19);
            checkBox_teslimEdildi.TabIndex = 14;
            checkBox_teslimEdildi.Text = "Teslim edildi";
            checkBox_teslimEdildi.UseVisualStyleBackColor = true;
            // 
            // textBox_kitapID
            // 
            textBox_kitapID.Dock = DockStyle.Top;
            textBox_kitapID.Location = new Point(0, 69);
            textBox_kitapID.Name = "textBox_kitapID";
            textBox_kitapID.PlaceholderText = "KitapID";
            textBox_kitapID.Size = new Size(150, 23);
            textBox_kitapID.TabIndex = 13;
            textBox_kitapID.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_TC
            // 
            textBox_TC.Dock = DockStyle.Top;
            textBox_TC.Location = new Point(0, 46);
            textBox_TC.Name = "textBox_TC";
            textBox_TC.PlaceholderText = "TC";
            textBox_TC.Size = new Size(150, 23);
            textBox_TC.TabIndex = 12;
            textBox_TC.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 271);
            label2.Name = "label2";
            label2.Size = new Size(150, 71);
            label2.TabIndex = 10;
            label2.Text = "en az 1 veri ile arama tuşuna basın ve yan taraftan teslimat seçin. (DOUBLE CLICK)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_teslimId
            // 
            textBox_teslimId.Dock = DockStyle.Top;
            textBox_teslimId.Location = new Point(0, 23);
            textBox_teslimId.Name = "textBox_teslimId";
            textBox_teslimId.PlaceholderText = "ID";
            textBox_teslimId.Size = new Size(150, 23);
            textBox_teslimId.TabIndex = 1;
            textBox_teslimId.TextAlign = HorizontalAlignment.Center;
            // 
            // button_teslimAra
            // 
            button_teslimAra.BackColor = Color.DeepSkyBlue;
            button_teslimAra.Dock = DockStyle.Top;
            button_teslimAra.Location = new Point(0, 0);
            button_teslimAra.Name = "button_teslimAra";
            button_teslimAra.Size = new Size(150, 23);
            button_teslimAra.TabIndex = 0;
            button_teslimAra.Text = "Search";
            button_teslimAra.UseVisualStyleBackColor = false;
            button_teslimAra.Click += button_teslimAra_Click;
            // 
            // listView_teslimatlar
            // 
            listView_teslimatlar.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader13 });
            listView_teslimatlar.Dock = DockStyle.Fill;
            listView_teslimatlar.FullRowSelect = true;
            listView_teslimatlar.GridLines = true;
            listView_teslimatlar.Location = new Point(0, 0);
            listView_teslimatlar.MultiSelect = false;
            listView_teslimatlar.Name = "listView_teslimatlar";
            listView_teslimatlar.Size = new Size(515, 342);
            listView_teslimatlar.TabIndex = 2;
            listView_teslimatlar.UseCompatibleStateImageBehavior = false;
            listView_teslimatlar.View = View.Details;
            listView_teslimatlar.DoubleClick += listView_teslimatlar_DoubleClick;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "id";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "TC";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "KitapID";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "alış";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "planlanan tarih";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "teslim tamamlama";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(label_teslimdetay);
            tabPage3.Controls.Add(dateTimePicker_odunc);
            tabPage3.Controls.Add(button_onayla);
            tabPage3.Controls.Add(label_teslimGunFark);
            tabPage3.Controls.Add(dateTimePicker_teslimEdilmesiGereken);
            tabPage3.Controls.Add(dateTimePicker_teslim);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(683, 352);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "detaylar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 132);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 10;
            label4.Text = "teslim tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "teslim sınır:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 74);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 8;
            label1.Text = "ödünç tarihi:";
            // 
            // label_teslimdetay
            // 
            label_teslimdetay.AutoSize = true;
            label_teslimdetay.Location = new Point(18, 17);
            label_teslimdetay.Name = "label_teslimdetay";
            label_teslimdetay.Size = new Size(179, 15);
            label_teslimdetay.TabIndex = 7;
            label_teslimdetay.Text = "seçili teslimat: teslimat seçilmedi";
            // 
            // dateTimePicker_odunc
            // 
            dateTimePicker_odunc.Enabled = false;
            dateTimePicker_odunc.Location = new Point(116, 74);
            dateTimePicker_odunc.Name = "dateTimePicker_odunc";
            dateTimePicker_odunc.Size = new Size(200, 23);
            dateTimePicker_odunc.TabIndex = 6;
            // 
            // button_onayla
            // 
            button_onayla.Location = new Point(66, 200);
            button_onayla.Name = "button_onayla";
            button_onayla.Size = new Size(196, 35);
            button_onayla.TabIndex = 5;
            button_onayla.Text = "Teslimat tamamlandı";
            button_onayla.UseVisualStyleBackColor = true;
            button_onayla.Click += button_onayla_Click;
            // 
            // label_teslimGunFark
            // 
            label_teslimGunFark.AutoSize = true;
            label_teslimGunFark.Location = new Point(25, 163);
            label_teslimGunFark.Name = "label_teslimGunFark";
            label_teslimGunFark.Size = new Size(37, 15);
            label_teslimGunFark.TabIndex = 4;
            label_teslimGunFark.Text = "0 gün";
            // 
            // dateTimePicker_teslimEdilmesiGereken
            // 
            dateTimePicker_teslimEdilmesiGereken.Enabled = false;
            dateTimePicker_teslimEdilmesiGereken.Location = new Point(116, 103);
            dateTimePicker_teslimEdilmesiGereken.Name = "dateTimePicker_teslimEdilmesiGereken";
            dateTimePicker_teslimEdilmesiGereken.Size = new Size(200, 23);
            dateTimePicker_teslimEdilmesiGereken.TabIndex = 3;
            // 
            // dateTimePicker_teslim
            // 
            dateTimePicker_teslim.Enabled = false;
            dateTimePicker_teslim.Location = new Point(116, 132);
            dateTimePicker_teslim.Name = "dateTimePicker_teslim";
            dateTimePicker_teslim.Size = new Size(200, 23);
            dateTimePicker_teslim.TabIndex = 2;
            // 
            // TeslimListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(691, 380);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeslimListesi";
            Text = "TeslimListesi";
            Load += TeslimListesi_Load;
            tabControl1.ResumeLayout(false);
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

        private TabControl tabControl1;
        private TabPage tabPage2;
        private SplitContainer splitContainer2;
        private Panel panel2;
        private Label label2;
        private TextBox textBox_kitapDurum;
        private TextBox textBox_kitapYayinevi;
        private TextBox textBox_kitapDil;
        private TextBox textBox_kitapBaskiYili;
        private TextBox textBox_kitapYazar;
        private TextBox textBox_kitapAd;
        private TextBox textBox_teslimId;
        private Button button_teslimAra;
        private ListView listView_teslimatlar;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader13;
        private TabPage tabPage3;
        private Button button_onayla;
        private Label label_teslimGunFark;
        private DateTimePicker dateTimePicker_teslimEdilmesiGereken;
        private DateTimePicker dateTimePicker_teslim;
        private Label label_teslimdetay;
        private DateTimePicker dateTimePicker_odunc;
        private CheckBox checkBox_teslimEdildi;
        private TextBox textBox_kitapID;
        private TextBox textBox_TC;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}