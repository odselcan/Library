using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class EmanetKitapListesi : Form
    {
        public EmanetKitapListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELCAN;Initial Catalog=Kutuphane;Integrated Security=True");
        //SqlConnection baglan = new SqlConnection(baglantısınıfı.sqlconnection);

        public void listele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EMANETKİTAPLİSTESİ", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void geribtn_Click(object sender, EventArgs e)
        {
            EmanetKitapListesi kapat = new EmanetKitapListesi();
            kapat.Close();
            Hide();
            EmanetKitapİsleri ac = new EmanetKitapİsleri();
            ac.Show();
        }
        private void EmanetKitapListesi_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EMANETKİTAPLİSTESİ where KİTAPID like '" + textBox1.Text + "%'", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EMANETKİTAPLİSTESİ where UYEID like '" + textBox2.Text + "%'", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
