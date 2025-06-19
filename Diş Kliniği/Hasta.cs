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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTbl values('" + HastaAdSoyadTb.Text + "','" + HastaTelefonTb.Text + "','" + HastaAdresTb.Text + "','" + HastaDogumTarihi.Text + "','" + HastaCinsiyetCb.SelectedItem.ToString() + "','" + HastaAlerjiTb.Text + "')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta Kaydı Başarılı");
                uyeler();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl where HAd like '%"+AramaTb.Text+"%'";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void reset()
        {
            HastaAdSoyadTb.Text = "";
            HastaTelefonTb.Text = "";
            HastaAdresTb.Text = "";
            HastaDogumTarihi.Text = "";
            HastaCinsiyetCb.SelectedItem = null;
            HastaAlerjiTb.Text = "";
            key = 0;
        }
        private void Hasta_Load(object sender, EventArgs e)
        {
          uyeler();
        }
        int key = 0;
        private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HastaTelefonTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            HastaAdresTb.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            HastaDogumTarihi.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            HastaCinsiyetCb.SelectedItem = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            HastaAlerjiTb.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (HastaAdSoyadTb.Text=="")
            {
                key = 0;
            }else
            {           
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
           

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
             MessageBox.Show("Silinecek Hastayı Seçiniz");
            } else
            { try
                {
                    string query = "Delete from HastaTbl where HId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Silindi");
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("güncellemek istediğiniz Hastayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Update  HastaTbl set HAd='" + HastaAdSoyadTb.Text + "',HTelefon='" + HastaTelefonTb.Text + "',HAdres='" + HastaAdresTb.Text + "',HDtarih='" + HastaDogumTarihi.Text + "',HCinsiyet='" + HastaCinsiyetCb.SelectedItem.ToString() + "',HAlerji='" + HastaAlerjiTb.Text + "' where HId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi");
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void AramaTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Reçeteler rc = new Reçeteler();
            rc.Show();
            this.Hide();
        }
    }
}
