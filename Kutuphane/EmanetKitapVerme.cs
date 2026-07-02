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
    public partial class EmanetKitapVerme : Form
    {
        public EmanetKitapVerme()
        {
            InitializeComponent();
        }
        //SqlConnection baglan = new SqlConnection(baglantısınıfı.sqlconnection);
        SqlConnection baglan = new SqlConnection("Data Source=SELCAN;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet daset = new DataSet();
        public void listele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from SEPET", baglan);
            adtr.Fill(daset, "SEPET");
            dataGridView1.DataSource = daset.Tables["SEPET"];
            baglan.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into SEPET (KİTAPID,KİTAP_AD,YAZAR,TESLİM_TARİHİ)values(@KİTAPID,@KİTAP_AD,@YAZAR,@TESLİM_TARİHİ)", baglan);
            komut.Parameters.AddWithValue("@KİTAPID", textBox2.Text);
            komut.Parameters.AddWithValue("@KİTAP_AD", textBox5.Text);
            komut.Parameters.AddWithValue("@YAZAR", textBox6.Text);
            komut.Parameters.AddWithValue("@TESLİM_TARİHİ", dateTimePicker1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kitap(lar) Eklendi", "Ekleme İşlemi");
            daset.Tables["SEPET"].Clear();
            listele();
        }
        private void EmanetKitapVerme_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();
        }
        private void txtUyeID_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from UYELER where UYEID like'" + txtUyeID.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox3.Text = read["AD"].ToString();
                textBox4.Text = read["SOYAD"].ToString();
                textBox1.Text = read["TELEFON"].ToString();
            }
            baglan.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from KITAP where KİTAPID like'" + textBox2.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox5.Text = read["KİTAPAD"].ToString();
                textBox6.Text = read["YAZAR"].ToString();
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from SEPET where KİTAPID='" + dataGridView1.CurrentRow.Cells["KİTAPID"].Value.ToString() + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silme işlemi yapıldı", "Silme İşlemi");
            daset.Tables["SEPET"].Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
                    if (txtUyeID.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglan.Open();
                            SqlCommand komut = new SqlCommand("insert into EMANETKİTAPLİSTESİ(KİTAPID,UYEID,AD,SOYAD,TELEFON,KİTAP_AD,YAZAR,TESLİM_TARİHİ)values(@KİTAPID,@UYEID,@AD,@SOYAD,@TELEFON,@KİTAP_AD,@YAZAR,@TESLİM_TARİHİ)", baglan);
                            komut.Parameters.AddWithValue("KİTAPID", dataGridView1.Rows[i].Cells["KİTAPID"].Value.ToString());
                            komut.Parameters.AddWithValue("@UYEID", txtUyeID.Text);
                            komut.Parameters.AddWithValue("@AD", textBox3.Text);
                            komut.Parameters.AddWithValue("@SOYAD", textBox4.Text);
                            komut.Parameters.AddWithValue("@TELEFON", textBox1.Text);
                            komut.Parameters.AddWithValue("KİTAP_AD", dataGridView1.Rows[i].Cells["KİTAP_AD"].Value.ToString());
                            komut.Parameters.AddWithValue("YAZAR", dataGridView1.Rows[i].Cells["YAZAR"].Value.ToString());
                            komut.Parameters.AddWithValue("TESLİM_TARİHİ", dataGridView1.Rows[i].Cells["TESLİM_TARİHİ"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("Update UYELER set oku", baglan);
                            baglan.Close();
                            MessageBox.Show("Kitap(lar) teslim edildi","Teslim İşlemi");
                            baglan.Open();
                            SqlCommand komut3 = new SqlCommand("Delete from SEPET where KİTAPID='" + dataGridView1.CurrentRow.Cells["KİTAPID"].Value.ToString() + "'", baglan);
                            komut3.ExecuteNonQuery();
                            baglan.Close();
                            daset.Tables["SEPET"].Clear(); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Önce Üye Seçmeniz Gerekir!!!", "UYARI");
                    }  
        }
        private void geribtn_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme kapat = new EmanetKitapVerme();
            kapat.Close();
            Hide();
            EmanetKitapİsleri ac = new EmanetKitapİsleri();
            ac.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }
    }
}
            
  
