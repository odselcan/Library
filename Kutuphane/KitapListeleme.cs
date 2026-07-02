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

namespace Kutuphane
{
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from KITAP where KİTAPID like '" + textBox1.Text + "%'or KİTAPAD like'" + textBox1.Text + "%'or YAZAR like'"+textBox1.Text+"%'", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void geribtn_Click(object sender, EventArgs e)
        {
            KitapListeleme kapat = new KitapListeleme();
            kapat.Close();
            Hide();
            Kitapİslemleri kitapİslemleri = new Kitapİslemleri();
            kitapİslemleri.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
