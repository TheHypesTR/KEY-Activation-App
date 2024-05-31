using Key_Control_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciUygulamasi
{
    public partial class KullaniciUygForm : Form
    {
        private string activationKey, configDosyasi, macadresi, yerelKey;
        readonly SqlConnection baglanti = new SqlConnection("Data Source=TheHypesTR;Initial Catalog = AktivasyonUyg;Integrated Security=True;Encrypt=False;");

        // Kullanıcı Daha Önce Key Bilgilerini Girdiyse Aktivasyon Sayfası Açılmaz.
        public KullaniciUygForm()
        {
            InitializeComponent();
            BaslangicTanimlamalari();

            if (yerelKey != null)
                if (MacAdresiVeKeyUyusuyorMu(yerelKey))
                    Application.Run(new AnasayfaForm());

                else
                {
                    if (KayitliMacAdresiVarMi())
                        MessageBox.Show("Cihazınız Daha Önce Etkinleştirilmiş! \r\nLütfen Key Sağlayıcınızla İletişime Geçip Key Bilgilerinizi İsteyiniz...", "Aktivasyon Hatası!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                        MessageBox.Show("Key Bilgisi Bulunamadı!! Lütfen Key Bilgilerinizi Giriniz...", "Aktivasyon Hatası!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        // Uygulamayı Kapat.
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Uygulamayı Simge Durumuna Geçirir.
        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Uygulama Hareketini Sağlayan Kısım.
        private bool mouseDown;
        private Point mouseDurum;
        private void TopbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDurum = e.Location;
        }

        private void TopbarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - mouseDurum.X) + e.X, (this.Location.Y - mouseDurum.Y) + e.Y);
                this.Update();
            }
        }

        private void TopbarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Çeşitli Görsel İyileştirmeler.
        private void ExitLabel_MouseHover(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.Red;
            ExitLabel.ForeColor = Color.White;
        }

        private void ExitLabel_MouseDown(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.DarkRed;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.PowderBlue;
            ExitLabel.ForeColor = Color.Black;
        }

        private void MinimizeLabel_MouseHover(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.DeepSkyBlue;
        }

        private void MinimizeLabel_MouseDown(Object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.DodgerBlue;
        }

        private void MinimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.PowderBlue;
        }

        private void ConfirmLabel_MouseDown(object sender, MouseEventArgs e)
        {
            GenerateKeyLabel.BackColor = Color.DodgerBlue;
        }

        private void ConfirmLabel_MouseHover(object sender, EventArgs e)
        {
            GenerateKeyLabel.BackColor = Color.DeepSkyBlue;
            Cursor = Cursors.Hand;
        }

        private void ConfirmLabel_MouseLeave(object sender, EventArgs e)
        {
            GenerateKeyLabel.BackColor = Color.PowderBlue;
            Cursor = Cursors.Default;
        }

        // Textbox'lara sadece Harf ve Rakam Girilmesini Sağlar.
        private void KeyTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;

            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´')
                e.Handled = true;
        }

        // Onayla Butonuna Tıklayınca Olacaklar.
        private void ConfirmLabel_Click(object sender, EventArgs e)
        {
            bool degerlerTamMi = DegerlerTamMi();
            if (degerlerTamMi)
            {
                if (KeySorgula())
                    if (!KayitliMacAdresiVarMi() || MacAdresiVeKeyUyusuyorMu(activationKey))
                        KeyKayit();

                    else
                        MessageBox.Show("Cihazınız Daha Önce Etkinleştirilmiş! \r\nLütfen Key Sağlayıcınızla İletişime Geçip Key Bilgilerinizi İsteyiniz...", "Aktivasyon Hatası!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Lütfen 16 Haneli Aktivasyon Key'inizi Giriniz!!", "Etkinleştirme Hatası!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Kullanıcı'nın Girdiği Key'in Database'deki Varlığını ve Başka Bir Kullanıcı Tarafından Kullanılıp Kullanılmadığını Denetler.
        private bool KeySorgula()
        {
            activationKey = (KeyTB1.Text + "-" + KeyTB2.Text + "-" + KeyTB3.Text + "-" + KeyTB4.Text).ToUpper();
            SqlCommand sqlKeyBul = new SqlCommand("SELECT * FROM KeyMgmt WHERE KeyCode = @KeyCode", baglanti);
            sqlKeyBul.Parameters.AddWithValue("@KeyCode", activationKey);
            baglanti.Open();
            SqlDataReader sqlReader = sqlKeyBul.ExecuteReader();

            if (sqlReader.Read())
                if (sqlReader[1] != null)
                {
                    if (sqlReader[2].ToString() == "0" || sqlReader[2].ToString() == macadresi)
                    {
                        MessageBox.Show("Ürün Anahtarınızı Onaylıyor Musunuz?\r\n" + sqlReader[1].ToString(), "Ürün Etkinleştirme!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlReader.Close();
                        baglanti.Close();
                        return true;
                    }

                    MessageBox.Show("Bu Key Daha Önce Kullanılmış!! \r\nLütfen Satıcınızla İletişime Geçiniz...", "Etkinleştirme Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlReader.Close();
                    baglanti.Close();
                    return false;
                }

            MessageBox.Show("Geçersiz Ürün Anahtarı!! Lütfen Satıcınıza Başvurunuz...", "Etkinleştirme Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlReader.Close();
            baglanti.Close();
            return false;
        }

        // Key Kaydına Kullanıcı Bilgileri Tanımlanır ve Bu Key Local'de de Tutulur.
        private void KeyKayit()
        {
            SqlCommand sqlKeyKaydet = new SqlCommand("UPDATE KeyMgmt SET MacAddress = @MacAddress, UserRegisterDate = @UserRegisterDate WHERE KeyCode = @ActivationKey", baglanti);
            sqlKeyKaydet.Parameters.AddWithValue("@MacAddress", macadresi);
            sqlKeyKaydet.Parameters.AddWithValue("@ActivationKey", activationKey);
            sqlKeyKaydet.Parameters.AddWithValue("@UserRegisterDate", DateTime.Now);
            baglanti.Open();
            sqlKeyKaydet.ExecuteNonQuery();

            Console.WriteLine(YerelKeyiKontrolEt(configDosyasi));
            if (YerelKeyiKontrolEt(configDosyasi) == null)
            {
                KeyiYerelDosyayaKaydet(configDosyasi, activationKey);
                MessageBox.Show("Key Aktivasyonu Başarılı Bir Şekilde Yapıldı!!", "Etkinleştirme Başarılı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnasayfaForm anasayfaForm = new AnasayfaForm();
                anasayfaForm.Show();
                this.Hide();
            }

            baglanti.Close();
        }

        // Yerel Key Var mı Diye Kontrol Eden Fonksiyon.
        private string YerelKeyiKontrolEt(string configDosyasi)
        {
            if (File.Exists(configDosyasi))
                using (StreamReader sr = new StreamReader(configDosyasi))
                {
                    string key = sr.ReadLine();
                    return key;
                }

            else
                return null;
        }

        // Kullanıcı Bilgileri Key'e Tanımlandıktan Sonra Key Local'de de Tutulur (Doğrulama için).
        private void KeyiYerelDosyayaKaydet(string configDosyasi, string yeniKey)
        {
            if (File.Exists(configDosyasi))
                File.WriteAllText(configDosyasi, string.Empty);

            else
                using (StreamWriter sw = File.CreateText(configDosyasi))
                    sw.WriteLine(yeniKey);
        }

        // Kullanıcının Mac Adresini Çeken Fonksiyon.
        public string MACAdresiniBul()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
                if (sMacAddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }

            return sMacAddress;
        }

        // Kullanıcının Key Bilgisi ile Mac Adresi'nin Uyuşup Uyuşmadığını Kontrol Eden Fonksiyon.
        private bool MacAdresiVeKeyUyusuyorMu(string keyCode)
        {
            SqlCommand sqlMacVeKeyBul = new SqlCommand("SELECT * FROM KeyMgmt WHERE MacAddress = @MacAddress AND KeyCode = @KeyCode", baglanti);
            sqlMacVeKeyBul.Parameters.AddWithValue("@MacAddress", macadresi);
            sqlMacVeKeyBul.Parameters.AddWithValue("@KeyCode", keyCode);
            baglanti.Open();
            SqlDataReader sqlReader = sqlMacVeKeyBul.ExecuteReader();
            if (sqlReader.Read())
            {
                sqlReader.Close();
                baglanti.Close();
                return true;
            }

            sqlReader.Close();
            baglanti.Close();
            return false;
        }

        // Kullanıcı'nın Önceden DB'ye Tanımlı Key'i Olup Olmadığını Sorgulayan Fonksiyon.
        private bool KayitliMacAdresiVarMi()
        {
            SqlCommand sqlMacBul = new SqlCommand("SELECT * FROM KeyMgmt WHERE MacAddress = @MacAddress", baglanti);
            sqlMacBul.Parameters.AddWithValue("@MacAddress", macadresi);
            baglanti.Open();
            SqlDataReader sqlReader = sqlMacBul.ExecuteReader();
            if (sqlReader.Read())
            {
                sqlReader.Close();
                baglanti.Close();
                return true;
            }

            sqlReader.Close();
            baglanti.Close();
            return false;
        }

        // Program Çalıştığında Değişkenlere Tanımlamar Yapan Fonksiyon.
        private void BaslangicTanimlamalari()
        {
            string mevcutDizin = Directory.GetCurrentDirectory();
            configDosyasi = Path.Combine(mevcutDizin, "ApplicationConfig.config");
            yerelKey = YerelKeyiKontrolEt(configDosyasi);
            macadresi = MACAdresiniBul();
            MacAddressLabel.Text = "MAC Adresiniz: " + macadresi;
        }

        // Textbox'ların Tamamının Dolu Olup Olmadığını Kontrol Eden Fonksiyon.
        private bool DegerlerTamMi()
        {
            if (KeyTB1.Text.Length == 4 && KeyTB2.Text.Length == 4 && KeyTB3.Text.Length == 4 && KeyTB4.Text.Length == 4)
                return true;

            return false;
        }
    }
}