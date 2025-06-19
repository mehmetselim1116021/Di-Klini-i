using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Diş_Kliniği
{
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "insert into TedaviTbl values('" + TedaviAdiTb.Text + "','" + TutarTb.Text + "','" + AciklamaTb.Text + "')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Tedavi planı Kaydı Başarılı");
                uyeler();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        int key = 0;
        private void DuzenleTb_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("güncellemek istediğiniz tedavi planını Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Update  TedaviTbl set Tad='" + TedaviAdiTb.Text + "',TUcret='" + TutarTb.Text + "',TAciklama='" + AciklamaTb.Text + "'  where TId=" + key + ";";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi planı Başarıyla Güncellendi");
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SilTb_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Tedavi planını Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete from TedaviTbl where TId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi planı başarıyla Silindi");
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from TedaviTbl";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from TedaviTbl where TAd like '%" + AramaTTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void reset()
        {
            TedaviAdiTb.Text = "";
            TutarTb.Text = "";
            AciklamaTb.Text = "";
            
        }
        private void Tedavi_Load(object sender, EventArgs e)
        {
            uyeler();
            reset();
        }

        private void TedaviDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TedaviAdiTb.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            TutarTb.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            AciklamaTb.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();
           
            if (TedaviAdiTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AramaTTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Reçeteler rc = new Reçeteler();
            rc.Show();
            this.Hide();
        }
    }
}
