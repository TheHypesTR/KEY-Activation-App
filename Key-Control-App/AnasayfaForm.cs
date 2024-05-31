using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciUygulamasi
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
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
    }
}
