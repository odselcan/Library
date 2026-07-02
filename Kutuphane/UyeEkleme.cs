using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane
{
    public partial class UyeEkleme : Form
    {
        public UyeEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELCAN;Initial Catalog=Kutuphane;Integrated Security=True");
        //SqlConnection baglan = new SqlConnection(baglantısınıfı.sqlconnection);
        public void listele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from UYELER", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into UYELER (TC,AD,SOYAD,TELEFON)values(@p1,@p2,@p3,@p4)", baglan);
            komut.Parameters.AddWithValue("@p1", tctxt.Text);
            komut.Parameters.AddWithValue("@p2", adtxt.Text);
            komut.Parameters.AddWithValue("@p3", soyadtxt.Text);
            komut.Parameters.AddWithValue("@p4",telefontxt.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt eklenmiştir..");
            listele();
        }
        private void UyeEkleme_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkleme kapat = new UyeEkleme();
            kapat.Close();
            Hide();
            UyeIslemleri ac =new UyeIslemleri();
            ac.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update UYELER Set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4 where UYEID=@p5", baglan);
            komut.Parameters.AddWithValue("@p1", adtxt.Text);
            komut.Parameters.AddWithValue("@p2", soyadtxt.Text);
            komut.Parameters.AddWithValue("@p3", telefontxt.Text);
            komut.Parameters.AddWithValue("@p4", tctxt.Text);
            komut.Parameters.AddWithValue("@p5", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Güncellenmiştir..");
            listele();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tctxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adtxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyadtxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefontxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }
    }
}
