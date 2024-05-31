using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AktivasyonUygulamasi
{
    public partial class KeyGeneratorForm : Form
    {
        readonly SqlConnection baglanti = new SqlConnection("Data Source=TheHypesTR;Initial Catalog = AktivasyonUyg;Integrated Security=True;Encrypt=False;");
        public KeyGeneratorForm()
        {
            InitializeComponent();
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

        private void GenerateKeyLabel_MouseDown(object sender, MouseEventArgs e)
        {
            GenerateKeyLabel.BackColor = Color.DodgerBlue;
        }

        private void GenerateKeyLabel_MouseHover(object sender, EventArgs e)
        {
            GenerateKeyLabel.BackColor = Color.DeepSkyBlue;
            Cursor = Cursors.Hand;
        }

        private void GenerateKeyLabel_MouseLeave(object sender, EventArgs e)
        {
            GenerateKeyLabel.BackColor = Color.PowderBlue;
            Cursor = Cursors.Default;
        }

        // "XXXX-XXXX-XXXX-XXXX" Biçiminde Key Üretir. Herhangi Bir Kullanıcıya Maximum Tek Key Gelecek Şekilde DB'de Tutulmaktadır.
        private void GenerateKeyLabel_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            string key = guid.ToString().Replace("-", "").Substring(0, 16).ToUpper();
            string refactoredKey = "";

            for (int i = 0; i < key.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                    refactoredKey += "-";

                refactoredKey += key[i];
            }
            
            KeyKayıt(refactoredKey);
            KeyLabel.Text = refactoredKey;
        }

        private void KeyKayıt(string activationKey)
        {
            SqlCommand sqlKeyKayit = new SqlCommand("INSERT INTO KeyMgmt (KeyCode) VALUES (@KeyCode)", baglanti);
            sqlKeyKayit.Parameters.AddWithValue("@KeyCode", activationKey);
            baglanti.Open();
            sqlKeyKayit.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}