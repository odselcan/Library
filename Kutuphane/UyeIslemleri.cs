using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }
        private void uyeeklebtn_Click(object sender, EventArgs e)
        {
            UyeEkleme uyeEkle = new UyeEkleme();
            uyeEkle.Show();
            Hide();
        }
        private void uyelistbtn_Click(object sender, EventArgs e)
        {
            UyeListele uyeListele = new UyeListele();
            uyeListele.Show();
            Hide();
        }
        private void uyesilbtn_Click(object sender, EventArgs e)
        {
            ÜyeSilme uyeSilme = new ÜyeSilme();
            uyeSilme.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(); 
            anasayfa.Show();
            Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        private void UyeIslemleri_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}
