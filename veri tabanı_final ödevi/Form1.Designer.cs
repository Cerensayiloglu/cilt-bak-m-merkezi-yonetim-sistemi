namespace veri_ödev_arayüz_kod1
{
    partial class btnekle
    {
        private System.ComponentModel.IContainer components = null;

         name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblCiroBilgi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamOdenen = new System.Windows.Forms.TextBox();
            this.txtSiparisTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSiparisKaydet = new System.Windows.Forms.Button();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSiparisKullanicilar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSeansKaydet = new System.Windows.Forms.Button();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.lblUrunSec = new System.Windows.Forms.Label();
            this.dtpSeansTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSeansTarih = new System.Windows.Forms.Label();
            this.btnPlanlariYenile = new System.Windows.Forms.Button();
            this.lstAktifPlanlar = new System.Windows.Forms.ListBox();
            this.lblPlanSec = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUzmanId = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvUzmanlar = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzmanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
     
            this.tabPage4.Controls.Add(this.lblCiroBilgi);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.lblToplamOdenen);
            this.tabPage4.Controls.Add(this.txtSiparisTutar);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btnSiparisKaydet);
            this.tabPage4.Controls.Add(this.cmbOdemeTuru);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.lstSiparisKullanicilar);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1254, 509);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sipariş Ekranı";
            this.tabPage4.UseVisualStyleBackColor = true;
    
            this.lblCiroBilgi.AutoSize = true;
            this.lblCiroBilgi.Location = new System.Drawing.Point(70, 351);
            this.lblCiroBilgi.Name = "lblCiroBilgi";
            this.lblCiroBilgi.Size = new System.Drawing.Size(80, 16);
            this.lblCiroBilgi.TabIndex = 10;
            this.lblCiroBilgi.Text = "cilt sorunları:";
  
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "TL";

            this.lblToplamOdenen.Location = new System.Drawing.Point(304, 305);
            this.lblToplamOdenen.Name = "lblToplamOdenen";
            this.lblToplamOdenen.Size = new System.Drawing.Size(100, 22);
            this.lblToplamOdenen.TabIndex = 8;
 
            this.txtSiparisTutar.Location = new System.Drawing.Point(573, 64);
            this.txtSiparisTutar.Name = "txtSiparisTutar";
            this.txtSiparisTutar.Size = new System.Drawing.Size(100, 22);
            this.txtSiparisTutar.TabIndex = 3;
 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Seçilen kullanıcının Toplam Ödemesi:";

            this.btnSiparisKaydet.Location = new System.Drawing.Point(67, 256);
            this.btnSiparisKaydet.Name = "btnSiparisKaydet";
            this.btnSiparisKaydet.Size = new System.Drawing.Size(87, 23);
            this.btnSiparisKaydet.TabIndex = 6;
            this.btnSiparisKaydet.Text = "Siparişi onayla";
            this.btnSiparisKaydet.UseVisualStyleBackColor = true;

            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "kart",
            "nakit"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(573, 99);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbOdemeTuru.TabIndex = 5;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödeme Türü";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sipariş Tutarı:";

            this.lstSiparisKullanicilar.FormattingEnabled = true;
            this.lstSiparisKullanicilar.ItemHeight = 16;
            this.lstSiparisKullanicilar.Location = new System.Drawing.Point(161, 64);
            this.lstSiparisKullanicilar.Name = "lstSiparisKullanicilar";
            this.lstSiparisKullanicilar.Size = new System.Drawing.Size(214, 84);
            this.lstSiparisKullanicilar.TabIndex = 1;
 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı seçin";
           
            this.tabPage3.Controls.Add(this.btnSeansKaydet);
            this.tabPage3.Controls.Add(this.numMiktar);
            this.tabPage3.Controls.Add(this.lblMiktar);
            this.tabPage3.Controls.Add(this.cmbUrunler);
            this.tabPage3.Controls.Add(this.lblUrunSec);
            this.tabPage3.Controls.Add(this.dtpSeansTarihi);
            this.tabPage3.Controls.Add(this.lblSeansTarih);
            this.tabPage3.Controls.Add(this.btnPlanlariYenile);
            this.tabPage3.Controls.Add(this.lstAktifPlanlar);
            this.tabPage3.Controls.Add(this.lblPlanSec);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1254, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bakım Planı & Seans";
            this.tabPage3.UseVisualStyleBackColor = true;
          
            this.btnSeansKaydet.Location = new System.Drawing.Point(463, 256);
            this.btnSeansKaydet.Name = "btnSeansKaydet";
            this.btnSeansKaydet.Size = new System.Drawing.Size(200, 40);
            this.btnSeansKaydet.TabIndex = 9;
            this.btnSeansKaydet.Text = "Seansı ve Ürünü Kaydet";
            this.btnSeansKaydet.UseVisualStyleBackColor = true;
           
            this.numMiktar.Location = new System.Drawing.Point(463, 197);
            this.numMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(120, 22);
            this.numMiktar.TabIndex = 8;
            this.numMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(460, 178);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(121, 16);
            this.lblMiktar.TabIndex = 7;
            this.lblMiktar.Text = "Kullanılacak Miktar:";
           
            this.cmbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(463, 131);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(250, 24);
            this.cmbUrunler.TabIndex = 6;
           
            this.lblUrunSec.AutoSize = true;
            this.lblUrunSec.Location = new System.Drawing.Point(460, 112);
            this.lblUrunSec.Name = "lblUrunSec";
            this.lblUrunSec.Size = new System.Drawing.Size(147, 16);
            this.lblUrunSec.TabIndex = 5;
            this.lblUrunSec.Text = "Kullanılacak Ürünü Seç:";
           
            this.dtpSeansTarihi.Location = new System.Drawing.Point(463, 62);
            this.dtpSeansTarihi.Name = "dtpSeansTarihi";
            this.dtpSeansTarihi.Size = new System.Drawing.Size(250, 22);
            this.dtpSeansTarihi.TabIndex = 4;
         
            this.lblSeansTarih.AutoSize = true;
            this.lblSeansTarih.Location = new System.Drawing.Point(460, 43);
            this.lblSeansTarih.Name = "lblSeansTarih";
            this.lblSeansTarih.Size = new System.Drawing.Size(86, 16);
            this.lblSeansTarih.TabIndex = 3;
            this.lblSeansTarih.Text = "Seans Tarihi:";
         
            this.btnPlanlariYenile.Location = new System.Drawing.Point(23, 335);
            this.btnPlanlariYenile.Name = "btnPlanlariYenile";
            this.btnPlanlariYenile.Size = new System.Drawing.Size(150, 30);
            this.btnPlanlariYenile.TabIndex = 2;
            this.btnPlanlariYenile.Text = "Listeyi Yenile";
            this.btnPlanlariYenile.UseVisualStyleBackColor = true;
     
            this.lstAktifPlanlar.FormattingEnabled = true;
            this.lstAktifPlanlar.ItemHeight = 16;
            this.lstAktifPlanlar.Location = new System.Drawing.Point(23, 62);
            this.lstAktifPlanlar.Name = "lstAktifPlanlar";
            this.lstAktifPlanlar.Size = new System.Drawing.Size(380, 260);
            this.lstAktifPlanlar.TabIndex = 1;
       
            this.lblPlanSec.AutoSize = true;
            this.lblPlanSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlanSec.Location = new System.Drawing.Point(20, 43);
            this.lblPlanSec.Name = "lblPlanSec";
            this.lblPlanSec.Size = new System.Drawing.Size(170, 16);
            this.lblPlanSec.TabIndex = 0;
            this.lblPlanSec.Text = "Aktif Bakım Planı Seçin:";
        
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtUzmanId);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cilt Analizi";
            this.tabPage2.UseVisualStyleBackColor = true;
            
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Aktif Sivilce / Akne",
            "Cilt Lekesi",
            "Geniş Gözenek",
            "Siyah Nokta",
            "Derin Kırışıklık"});
            this.checkedListBox1.Location = new System.Drawing.Point(104, 141);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(160, 89);
            this.checkedListBox1.TabIndex = 8;
         
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Analiz Kaydet";
            this.button2.UseVisualStyleBackColor = true;
         
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "karma",
            "yağlı",
            "kuru",
            "normal"});
            this.comboBox1.Location = new System.Drawing.Point(103, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
             
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cilt Tipi:";
            
            this.textBox2.Location = new System.Drawing.Point(103, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 22);
            this.textBox2.TabIndex = 3;
          
            this.textBox1.Location = new System.Drawing.Point(96, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 22);
            this.textBox1.TabIndex = 1;
         
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı ID:";
          
            this.txtUzmanId.AutoSize = true;
            this.txtUzmanId.Location = new System.Drawing.Point(21, 31);
            this.txtUzmanId.Name = "txtUzmanId";
            this.txtUzmanId.Size = new System.Drawing.Size(68, 16);
            this.txtUzmanId.TabIndex = 0;
            this.txtUzmanId.Text = "Uzman ID:";
           
            this.tabPage1.Controls.Add(this.dgvUzmanlar);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.dgvKullanicilar);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmbCinsiyet);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcı İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
        
            this.dgvUzmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUzmanlar.Location = new System.Drawing.Point(432, 340);
            this.dgvUzmanlar.Name = "dgvUzmanlar";
            this.dgvUzmanlar.RowHeadersWidth = 51;
            this.dgvUzmanlar.RowTemplate.Height = 24;
            this.dgvUzmanlar.Size = new System.Drawing.Size(780, 111);
            this.dgvUzmanlar.TabIndex = 15;
             
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(429, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Uzmanlar:";
       
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(399, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Kullanıcılar:";
         
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(418, 44);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(815, 152);
            this.dgvKullanicilar.TabIndex = 12;
         
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Kullanıcı ";
      
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cinsiyet";
            // 
         
        
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "E-posta";
         
       
          
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Telefon";

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Soyad";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "İsim:";
            this.txtAd.Location = new System.Drawing.Point(170, 38);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 2;
            this.txtEmail.Location = new System.Drawing.Point(170, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 5;
            this.txtSoyad.Location = new System.Drawing.Point(170, 84);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 3;
            this.txtTelefon.Location = new System.Drawing.Point(170, 133);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 4; 
            this.button1.Location = new System.Drawing.Point(73, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "kadın",
            "erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(170, 221);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cmbCinsiyet.TabIndex = 1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 538);
            this.tabControl1.TabIndex = 6;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "btnekle";
            this.Text = "Bakım Merkezi Yönetim Sistemi";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzmanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblCiroBilgi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblToplamOdenen;
        private System.Windows.Forms.TextBox txtSiparisTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSiparisKaydet;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSiparisKullanicilar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSeansKaydet;
        private System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Label lblUrunSec;
        private System.Windows.Forms.DateTimePicker dtpSeansTarihi;
        private System.Windows.Forms.Label lblSeansTarih;
        private System.Windows.Forms.Button btnPlanlariYenile;
        private System.Windows.Forms.ListBox lstAktifPlanlar;
        private System.Windows.Forms.Label lblPlanSec;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUzmanId;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvUzmanlar;
    }
}