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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Kutuphane
{
    public partial class UyeListele : Form 
    {
        public UyeListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELCAN;Initial Catalog=Kutuphane;Integrated Security=True");
        //SqlConnection baglan = new SqlConnection(baglantısınıfı.sqlconnection);
        public void listele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from UYELER",baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource= tablo;
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           listele();
        }
        private void UyeListele_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();   
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from UYELER where UYEID like '"+textBox1.Text+"%' or TC like  '" + textBox1.Text + "%'or AD like'"+textBox1.Text+ "%'or SOYAD like'"+textBox1.Text+"%' or TELEFON like '"+textBox1.Text+"%'", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           UyeListele kapat = new UyeListele();
           kapat.Close();
           Hide();
           UyeIslemleri ac = new UyeIslemleri();
           ac.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
