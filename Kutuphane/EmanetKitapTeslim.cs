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

namespace Kutuphane
{
    public partial class EmanetKitapTeslim : Form
    {
        public EmanetKitapTeslim()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EMANETKİTAPLİSTESİ where KİTAPID like '" + textBox1.Text + "%'", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void EmanetKitapTeslim_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();
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
        private void geribtn_Click(object sender, EventArgs e)
        {
            EmanetKitapTeslim kapat = new EmanetKitapTeslim();
            kapat.Close();
            Hide();
            EmanetKitapİsleri ac = new EmanetKitapİsleri();
            ac.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from EMANETKİTAPLİSTESİ where KİTAPID ='" + textBox3.Text.ToString() + "' AND UYEID ='"+textBox4.Text.ToString()+"'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
            MessageBox.Show("Kitap teslim alınmıştır...");
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox3.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

    }
}
