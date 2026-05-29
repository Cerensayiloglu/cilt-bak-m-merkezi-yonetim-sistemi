using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace veri_ödev_arayüz_kod1
{
    public partial class btnekle : Form
    {
        public class PlanItem
        {
            public int PlanId { get; set; }
            public string GosterimMetni { get; set; }
            public override string ToString() => GosterimMetni;
        }

        public class UrunItem
        {
            public int UrunId { get; set; }
            public string UrunAdi { get; set; }
            public override string ToString() => UrunAdi;
        }

        public class KullaniciItem
        {
            public int KullaniciId { get; set; }
            public string AdSoyad { get; set; }
            public override string ToString() => AdSoyad;
        }

    
        public btnekle()
        {
            InitializeComponent();

            if (this.button1 != null) this.button1.Location = new System.Drawing.Point(6, 242);
            if (this.button2 != null) this.button2.Location = new System.Drawing.Point(24, 253);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

   
            if (this.button1 != null) this.button1.Click += new EventHandler(btnKullaniciEkle_Click);

   
            if (this.button2 != null) this.button2.Click += new EventHandler(btnAnalizKaydet_Click);

          
            if (this.btnPlanlariYenile != null) this.btnPlanlariYenile.Click += new EventHandler(btnPlanlariYenile_Click);
            if (this.btnSeansKaydet != null) this.btnSeansKaydet.Click += new EventHandler(btnSeansKaydet_Click);

            if (this.btnSiparisKaydet != null) this.btnSiparisKaydet.Click += new EventHandler(btnSiparisKaydet_Click);
            if (this.lstSiparisKullanicilar != null) this.lstSiparisKullanicilar.SelectedIndexChanged += new EventHandler(lstSiparisKullanicilar_SelectedIndexChanged);

       
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            BakimPlanlariniListele();
            UrunleriDoldur();
            SiparisKullanicilariniListele();
            KullanicilariGriddeListele(); 
            UzmanlariGriddeListele();    
        }

        private void KullanicilariGriddeListele()
        {
            Control[] grids = this.Controls.Find("dgvKullanicilar", true);
            if (grids.Length == 0) return;

            DataGridView dgv = (DataGridView)grids[0];

            string sorgu = "SELECT kullanıcı_id AS 'Kullanıcı ID', ad AS 'Adı', soyad AS 'Soyadı', telefon AS 'Telefon', e_mail AS 'E-Posta', cinsiyet AS 'Cinsiyet' FROM kullanıcı";

            DataTable dt = VeriTabani.VeriGetir(sorgu);
            if (dt != null)
            {
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
            }
        }

        private void UzmanlariGriddeListele()
        {
            Control[] grids = this.Controls.Find("dgvUzmanlar", true);
            if (grids.Length == 0) return;

            DataGridView dgv = (DataGridView)grids[0];
            string sorgu = "SELECT uzman_id AS 'Uzman ID', u_ad AS 'Adı', u_soyad AS 'Soyadı', uzmanlık AS 'Uzmanlık Alanı' FROM uzman";

            DataTable dt = VeriTabani.VeriGetir(sorgu);
            if (dt != null)
            {
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cinsiyet = cmbCinsiyet.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(ad) || ad.Contains("İSİM") || string.IsNullOrEmpty(soyad) || soyad.Contains("SOYADI"))
            {
                MessageBox.Show("Lütfen geçerli bir Ad ve Soyad giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefon.Contains("TELEFON")) telefon = "";
            if (email.Contains("E-POSTA")) email = "";
            string sqlSorgusu = "INSERT INTO kullanıcı (ad, soyad, telefon, e_mail, cinsiyet) VALUES (@ad, @soyad, @telefon, @email, @cinsiyet)";
            MySqlParameter[] parametreler = {
                new MySqlParameter("@ad", ad),
                new MySqlParameter("@soyad", soyad),
                new MySqlParameter("@telefon", string.IsNullOrEmpty(telefon) ? DBNull.Value : (object)telefon),
                new MySqlParameter("@email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email),
                new MySqlParameter("@cinsiyet", string.IsNullOrEmpty(cinsiyet) || cinsiyet.Contains("CİNSİYET") ? DBNull.Value : (object)cinsiyet)
            };

            int sonuc = VeriTabani.KomutCalistir(sqlSorgusu, parametreler);
            if (sonuc > 0)
            {
                MessageBox.Show("Kullanıcı başarıyla veritabanına eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAd.Clear(); txtSoyad.Clear(); txtTelefon.Clear(); txtEmail.Clear();
                cmbCinsiyet.SelectedIndex = -1;

                SiparisKullanicilariniListele();
                KullanicilariGriddeListele();
            }
        }

        private void btnAnalizKaydet_Click(object sender, EventArgs e)
        {
            Control[] t1 = this.Controls.Find("textBox1", true);
            Control[] t2 = this.Controls.Find("textBox2", true);
            Control[] c1 = this.Controls.Find("comboBox1", true);
            Control[] chkList = this.Controls.Find("checkedListBox1", true);

            if (t1.Length == 0 || t2.Length == 0 || c1.Length == 0 || chkList.Length == 0) return;

            string uzmanId = ((TextBox)t1[0]).Text.Trim();
            string kullaniciId = ((TextBox)t2[0]).Text.Trim();
            string ciltTipi = ((ComboBox)c1[0]).SelectedItem?.ToString();
            CheckedListBox chk = (CheckedListBox)chkList[0];
            string analizTarihi = DateTime.Now.ToString("yyyy-MM-dd");

            int hesaplananCiltSkoru = 100;
            foreach (object item in chk.CheckedItems)
            {
                string sorun = item.ToString();
                if (sorun.Contains("Sivilce") || sorun.Contains("akne")) hesaplananCiltSkoru -= 25;
                if (sorun.Contains("Lekesi") || sorun.Contains("leke")) hesaplananCiltSkoru -= 20;
                if (sorun.Contains("Gözenek")) hesaplananCiltSkoru -= 15;
                if (sorun.Contains("Kırışıklık")) hesaplananCiltSkoru -= 20;
            }
            if (hesaplananCiltSkoru < 0) hesaplananCiltSkoru = 0;

           
            string sqlSorgusu = "INSERT INTO cilt_analizi (uzman_id, kullanıcı_id, analiz_tarihi, cilt_tipi, cilt_skoru) VALUES (@uzmanId, @kullaniciId, @analizTarihi, @ciltTipi, @ciltSkoru)";
            MySqlParameter[] parametreler = {
                new MySqlParameter("@uzmanId", Convert.ToInt32(uzmanId)),
                new MySqlParameter("@kullaniciId", Convert.ToInt32(kullaniciId)),
                new MySqlParameter("@analizTarihi", analizTarihi),
                new MySqlParameter("@ciltTipi", ciltTipi),
                new MySqlParameter("@ciltSkoru", hesaplananCiltSkoru)
            };

            int sonuc = VeriTabani.KomutCalistir(sqlSorgusu, parametreler);
            if (sonuc > 0)
            {
                MessageBox.Show("Cilt Analizi başarıyla kaydedildi! (Not: Tetikleyici sayesinde bakım planı otomatik oluşturuldu.)", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BakimPlanlariniListele();
                ((TextBox)t1[0]).Clear(); ((TextBox)t2[0]).Clear(); ((ComboBox)c1[0]).SelectedIndex = -1;
                for (int i = 0; i < chk.Items.Count; i++) chk.SetItemChecked(i, false);
            }
        }

        {
            if (lstAktifPlanlar == null) return;
            lstAktifPlanlar.Items.Clear();
            string sorgu = @"SELECT bp.plan_id, k.ad, k.soyad, ca.cilt_tipi 
                             FROM bakim_planı bp
                             JOIN cilt_analizi ca ON bp.analiz_id = ca.Analiz_id
                             JOIN kullanıcı k ON ca.kullanıcı_id = k.kullanıcı_id";

            DataTable dt = VeriTabani.VeriGetir(sorgu);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lstAktifPlanlar.Items.Add(new PlanItem
                    {
                        PlanId = Convert.ToInt32(row["plan_id"]),
                        GosterimMetni = $"[Plan ID: {row["plan_id"]}] - {row["ad"]} {row["soyad"]} ({row["cilt_tipi"]})"
                    });
                }
            }
        }

        private void UrunleriDoldur()
        {
            if (cmbUrunler == null) return;
            cmbUrunler.Items.Clear();
            string sorgu = "SELECT urun_id, urun_adi, stok FROM urun WHERE stok > 0";
            DataTable dt = VeriTabani.VeriGetir(sorgu);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cmbUrunler.Items.Add(new UrunItem
                    {
                        UrunId = Convert.ToInt32(row["urun_id"]),
                        UrunAdi = $"{row["urun_adi"]} (Stok: {row["stok"]})"
                    });
                }
            }
        }

        private void btnPlanlariYenile_Click(object sender, EventArgs e)
        {
            VerileriYukle();
            MessageBox.Show("Tüm listeler, tablolar ve ürün stokları güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeansKaydet_Click(object sender, EventArgs e)
        {
            if (lstAktifPlanlar.SelectedItem == null || cmbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen listeden plan ve ürün seçimlerini eksiksiz yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenPlanId = ((PlanItem)lstAktifPlanlar.SelectedItem).PlanId;
            int secilenUrunId = ((UrunItem)cmbUrunler.SelectedItem).UrunId;
            int miktar = Convert.ToInt32(numMiktar.Value);
            string seansTarihi = dtpSeansTarihi.Value.ToString("yyyy-MM-dd");

            string seansSorgu = "INSERT INTO seans (plan_id, seans_tarihi) VALUES (@planId, @seansTarihi)";
            MySqlParameter[] seansParam = {
                new MySqlParameter("@planId", secilenPlanId),
                new MySqlParameter("@seansTarihi", seansTarihi)
            };

            int seansSonuc = VeriTabani.KomutCalistir(seansSorgu, seansParam);
            if (seansSonuc > 0)
            {
                string sonIdSorgu = "SELECT LAST_INSERT_ID()";
                DataTable dtId = VeriTabani.VeriGetir(sonIdSorgu);
                int sonSeansId = Convert.ToInt32(dtId.Rows[0][0]);

                
                string exUrunSorgu = "INSERT INTO ex_urun (urun_id, seans_id, miktar) VALUES (@urunId, @seansId, @miktar)";
                MySqlParameter[] exParam = {
                    new MySqlParameter("@urunId", secilenUrunId),
                    new MySqlParameter("@seansId", sonSeansId),
                    new MySqlParameter("@miktar", miktar)
                };

                int exSonuc = VeriTabani.KomutCalistir(exUrunSorgu, exParam);
                if (exSonuc > 0)
                {
                    MessageBox.Show("Seans başarıyla oluşturuldu ve Stok Tetikleyicisi çalıştı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UrunleriDoldur(); 
                }
            }
        }

        private void SiparisKullanicilariniListele()
        {
            if (lstSiparisKullanicilar == null) return;
            lstSiparisKullanicilar.Items.Clear();

            string sorgu = "SELECT kullanıcı_id, ad, soyad FROM kullanıcı";
            DataTable dt = VeriTabani.VeriGetir(sorgu);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lstSiparisKullanicilar.Items.Add(new KullaniciItem
                    {
                        KullaniciId = Convert.ToInt32(row["kullanıcı_id"]),
                        AdSoyad = $"[ID: {row["kullanıcı_id"]}] - {row["ad"]} {row["soyad"]}"
                    });
                }
            }
        }

        private void lstSiparisKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSiparisKullanicilar == null || lstSiparisKullanicilar.SelectedItem == null) return;

            int secilenKullaniciId = ((KullaniciItem)lstSiparisKullanicilar.SelectedItem).KullaniciId;

            string harcamaSorgusu = "SELECT fn_toplam_odeme(@kullaniciId)";
            MySqlParameter[] param1 = { new MySqlParameter("@kullaniciId", secilenKullaniciId) };

            DataTable dtHarcama = VeriTabani.VeriGetir(harcamaSorgusu, param1);
            if (dtHarcama != null && dtHarcama.Rows.Count > 0 && lblToplamOdenen != null)
            {
                lblToplamOdenen.Text = dtHarcama.Rows[0][0].ToString() + " TL";
            }

            string sonAnalizSorgusu = "SELECT Analiz_id FROM cilt_analizi WHERE kullanıcı_id = @kullaniciId ORDER BY analiz_tarihi DESC LIMIT 1";
            MySqlParameter[] param2 = { new MySqlParameter("@kullaniciId", secilenKullaniciId) };
            DataTable dtAnaliz = VeriTabani.VeriGetir(sonAnalizSorgusu, param2);

            Control[] ciroLabels = this.Controls.Find("lblCiroBilgi", true);
            Label lblCiro = ciroLabels.Length > 0 ? (Label)ciroLabels[0] : null;

            if (dtAnaliz != null && dtAnaliz.Rows.Count > 0)
            {
                int sonAnalizId = Convert.ToInt32(dtAnaliz.Rows[0]["Analiz_id"]);

                string problemSorgusu = "SELECT fn_problem_bulma(@analizId)";
                MySqlParameter[] param3 = { new MySqlParameter("@analizId", sonAnalizId) };
                DataTable dtProblem = VeriTabani.VeriGetir(problemSorgusu, param3);

                if (dtProblem != null && dtProblem.Rows.Count > 0 && lblCiro != null)
                {
                    int problemSayisi = Convert.ToInt32(dtProblem.Rows[0][0]);
                    lblCiro.Text = $"Kullanıcının Son Analizindeki Cilt Problemi Sayısı: {problemSayisi}";
                }
            }
            else
            {
                if (lblCiro != null)
                {
                    lblCiro.Text = "Bu kullanıcıya ait bir cilt analizi bulunamadı.";
                }
            }
        }

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            if (lstSiparisKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sipariş için listeden bir kullanıcı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSiparisTutar == null || string.IsNullOrEmpty(txtSiparisTutar.Text) || cmbOdemeTuru == null || cmbOdemeTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tutar alanını ve ödeme türünü doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenKullaniciId = ((KullaniciItem)lstSiparisKullanicilar.SelectedItem).KullaniciId;
            int tutar;
            if (!int.TryParse(txtSiparisTutar.Text.Trim(), out tutar))
            {
                MessageBox.Show("Lütfen tutar kısmına sadece tam sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string odemeTuru = cmbOdemeTuru.SelectedItem.ToString();

           
            string sqlSorgu = "INSERT INTO siparis (kullanıcı_id, tutar, odeme_turu) VALUES (@kullaniciId, @tutar, @odemeTuru)";
            MySqlParameter[] parametreler = {
                new MySqlParameter("@kullaniciId", secilenKullaniciId),
                new MySqlParameter("@tutar", tutar),
                new MySqlParameter("@odemeTuru", odemeTuru)
            };

            int sonuc = VeriTabani.KomutCalistir(sqlSorgu, parametreler);
            if (sonuc > 0)
            {
                MessageBox.Show("Sipariş veritabanına başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSiparisTutar.Clear();
                cmbOdemeTuru.SelectedIndex = -1;

            
                lstSiparisKullanicilar_SelectedIndexChanged(null, null);
            }
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e) { }
    }

    public static class VeriTabani
    {
        private static string[] alternatifSifreler = { "Ceren321.", "1234", "" };
        private static string calisanBaglantiCumlesi = null;

        private static string BaglantiCumlesiBul()
        {
            if (calisanBaglantiCumlesi != null) return calisanBaglantiCumlesi;
            foreach (var sifre in alternatifSifreler)
            {
               
                string testCumlesi = $"Server=localhost;Database=bakım_merkezi;Uid=root;Pwd={sifre};Charset=utf8;";
                using (MySqlConnection conn = new MySqlConnection(testCumlesi))
                {
                    try { conn.Open(); calisanBaglantiCumlesi = testCumlesi; return calisanBaglantiCumlesi; } catch { }
                }
            }
            return "Server=localhost;Database=bakım_merkezi;Uid=root;Pwd=Ceren321.;Charset=utf8;";
        }

        public static MySqlConnection BaglantiAl() => new MySqlConnection(BaglantiCumlesiBul());

        public static DataTable VeriGetir(string sqlSorgusu, MySqlParameter[] parametreler = null)
        {
            DataTable tablo = new DataTable();
            using (MySqlConnection baglanti = BaglantiAl())
            {
                using (MySqlCommand komut = new MySqlCommand(sqlSorgusu, baglanti))
                {
                    if (parametreler != null) komut.Parameters.AddRange(parametreler);
                    using (MySqlDataAdapter adaptor = new MySqlDataAdapter(komut))
                    {
                        try { baglanti.Open(); adaptor.Fill(tablo); }
                        catch (Exception ex) { MessageBox.Show("Veri çekme hatası: " + ex.Message); return null; }
                    }
                }
            }
            return tablo;
        }

        public static int KomutCalistir(string sqlSorgusu, MySqlParameter[] parametreler = null)
        {
            int etkilenenSatir = 0;
            using (MySqlConnection baglanti = BaglantiAl())
            {
                using (MySqlCommand komut = new MySqlCommand(sqlSorgusu, baglanti))
                {
                    if (parametreler != null) komut.Parameters.AddRange(parametreler);
                    try { baglanti.Open(); etkilenenSatir = komut.ExecuteNonQuery(); }
                    catch (Exception ex) { MessageBox.Show("Komut çalıştırma hatası: " + ex.Message); }
                }
            }
            return etkilenenSatir;
        }
    }
}