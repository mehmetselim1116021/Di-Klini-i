using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diş_Kliniği
{
    public partial class Reçeteler : Form
    {
        public Reçeteler()
        {
            InitializeComponent();
        }

        ConnectionString MyCon = new ConnectionString();
        private void fillHasta()
        {
            SqlConnection baglanti = MyCon.GetCon();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HAd from HastaTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HAd", typeof(string));
            dt.Load(rdr);
            HastaAsCb.ValueMember = "HAd";
            HastaAsCb.DataSource = dt;
            baglanti.Close();
        }

        private void fillTedavi()
        {
            SqlConnection baglanti = MyCon.GetCon();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from RandevuTbl where Hasta='" + HastaAsCb.SelectedValue.ToString() + "'", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                {
                    TedaviTb.Text = dr["Tedavi"].ToString();
                }
                baglanti.Close();
            }

        }

            private void fillPrice()
            {
                SqlConnection baglanti = MyCon.GetCon();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from TedaviTbl where TAd='" + TedaviTb.Text + "'", baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(komut);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    {
                         TutarTb.Text = dr["TUcret"].ToString();
                    }
                    baglanti.Close();
                }

            }

        private void Reçeteler_Load(object sender, EventArgs e)
        {
            fillHasta();
            uyeler();
            reset();
        }

        private void HastaAsCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillTedavi();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void TutarTb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TedaviTb_TextChanged(object sender, EventArgs e)
        {
            fillPrice();
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from ReceteTbl";
            DataSet ds = Hs.ShowHasta(query);
            ReceteDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from ReceteTbl where HastaAd like '%" + AraTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            ReceteDGV.DataSource = ds.Tables[0];
        }
        void reset()
        {
            HastaAsCb.SelectedItem = "";
            TedaviTb.Text = "";
            TutarTb.Text = "";
            ilacTb.Text = "";
            MiktarTb.Text = "";

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "insert into ReceteTbl values('" + HastaAsCb.SelectedValue.ToString() + "','" + TedaviTb.Text + "'," + TutarTb.Text + ",'"+ilacTb.Text+"',"+MiktarTb.Text+")";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Reçete Kaydı Başarılı");
                uyeler();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        int key = 0;

        private void HastaAsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTedavi();
        }

        
        private void ReceteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaAsCb.Text = ReceteDGV.SelectedRows[0].Cells[1].Value.ToString();
            TedaviTb.Text = ReceteDGV.SelectedRows[0].Cells[2].Value.ToString();
            TutarTb.Text = ReceteDGV.SelectedRows[0].Cells[3].Value.ToString();
            ilacTb.Text = ReceteDGV.SelectedRows[0].Cells[4].Value.ToString();
            MiktarTb.Text = ReceteDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (TedaviTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceteDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Reçete kaydını Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete from ReceteTbl where RId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Reçete kaydı Silindi");
                    uyeler();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AraTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        Bitmap bitmap;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int height = ReceteDGV.Height;
            ReceteDGV.Height = ReceteDGV.RowCount * ReceteDGV.RowTemplate.Height * 2;
            bitmap=new Bitmap(ReceteDGV.Width, ReceteDGV.Height);
            ReceteDGV.DrawToBitmap(bitmap, new Rectangle(0, 0, ReceteDGV.Width, ReceteDGV.Height));
            ReceteDGV.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }
    }
    }
    
