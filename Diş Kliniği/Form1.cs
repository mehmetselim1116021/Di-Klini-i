using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diş_Kliniği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string dogruKullaniciAdi = "admin";
            string dogruParola = "12345";

            string girilenKullaniciAdi = KullaniciTb.Text.Trim();
            string girilenParola = ParolaTb.Text;

            if (girilenKullaniciAdi == dogruKullaniciAdi && girilenParola == dogruParola)
            {
                lbldurum.Text = "Giriş başarılı! 👏";
                lbldurum.ForeColor = Color.Green;

                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                lbldurum.Text = "Kullanıcı adı veya parola yanlış!";
                lbldurum.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
