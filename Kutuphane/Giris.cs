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
    
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=SELCAN;Initial Catalog=Kutuphane;Integrated Security=True");
        //SqlConnection baglan = new SqlConnection(baglantısınıfı.sqlconnection);
        SqlCommand com;
        SqlDataReader dr;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            baglan.Open();
            SqlCommand komut=new SqlCommand("Select *From Giris where kullanıcıadi='" + textBox1.Text.ToString() + "' And parola='" + textBox2.Text.ToString() + "'",baglan);
            dr=komut.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Giriş Başarılı..");
                Giris kapat = new Giris();
                kapat.Close();
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            baglan.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
