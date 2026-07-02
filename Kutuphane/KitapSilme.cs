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
    public partial class KitapSilme : Form
    {
        public KitapSilme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELCAN;Initial Catalog=Kutuphane;Integrated Security=True");
        //SqlConnection baglan = new SqlConnection(baglantısınıfı.sqlconnection);
        public void listele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from KITAP", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from KITAP where KİTAPıD ='" + siltxt.Text.ToString() + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
            MessageBox.Show("Kitap Silinmiştir...");
        }
        private void KitapSilme_Load(object sender, EventArgs e)
        {
            listele();  
            timer1.Start();
        }
        private void geribtn_Click(object sender, EventArgs e)
        {
            KitapSilme kitapSilme=new KitapSilme();
            kitapSilme.Close();
            Hide();
            Kitapİslemleri kitapİslemleri = new Kitapİslemleri();
            kitapİslemleri.Show();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            siltxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

    }
}
