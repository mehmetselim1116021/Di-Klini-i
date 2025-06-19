using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Input;

namespace Diş_Kliniği
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }
        ConnectionString MyCon=new ConnectionString();
        private void fillHasta()
        { SqlConnection baglanti = MyCon.GetCon();
        
        baglanti.Open();
            SqlCommand komut = new SqlCommand("select HAd from HastaTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
           DataTable dt = new DataTable();
            dt.Columns.Add("HAd", typeof(string));
            dt.Load(rdr);
            RandevuCb.ValueMember= "HAd";
            RandevuCb.DataSource = dt;
            baglanti.Close();
        }

        private void fillTedavi()
        {
            SqlConnection baglanti = MyCon.GetCon();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Tad from TedaviTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tad", typeof(string));
            dt.Load(rdr);
            RandevuTedaviCb.ValueMember = "Tad";
            RandevuTedaviCb.DataSource = dt;
            baglanti.Close();
        }
        private void Randevu_Load(object sender, EventArgs e)
        {
            fillHasta();
            fillTedavi();
            uyeler();
            reset();
        }

        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from RandevuTbl";
            DataSet ds = Hs.ShowHasta(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from RandevuTbl where Hasta like '%" + AramaRTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }
        void reset()
        {
            RandevuCb.SelectedIndex = -1;
            RandevuTedaviCb.SelectedIndex = -1;
            RandevuTarihDTP.Text = "";
            RandevuSaatCb.SelectedIndex = -1;
            
        } 
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "insert into RandevuTbl values('" + RandevuCb.Text + "','" + RandevuTedaviCb.SelectedValue.ToString() + "','" + RandevuTarihDTP.Text + "','"+RandevuSaatCb.Text+"')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Randevu planı Kaydı Başarılı");
                uyeler();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        int key = 0;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("güncellemek istediğiniz Randevu planını Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Update  RandevuTbl set Hasta='" + RandevuCb.Text + "',Tedavi='" + RandevuTedaviCb.Text + "',RTarihi='" + RandevuTarihDTP.Text + "',Rsaat='"+RandevuSaatCb.Text+"'  where RId=" + key + ";";
                    Hs.HastaSil(query);
                    MessageBox.Show("Randevu planı Başarıyla Güncellendi");
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RandevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RandevuCb.SelectedValue = RandevuDGV.SelectedRows[0].Cells[1].Value.ToString();
            RandevuTedaviCb.SelectedValue = RandevuDGV.SelectedRows[0].Cells[2].Value.ToString();
            RandevuTarihDTP.Text = RandevuDGV.SelectedRows[0].Cells[3].Value.ToString();
            RandevuSaatCb.Text = RandevuDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (RandevuCb.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(RandevuDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Randevu planını Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete from RandevuTbl where RId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Randevu planı başarıyla Silindi");
                    uyeler();
                   // reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {

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

        private void AramaRTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Reçeteler rc = new Reçeteler();
            rc.Show();
            this.Hide();
        }
    }
}
