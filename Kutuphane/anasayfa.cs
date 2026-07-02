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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void Uye_Click(object sender, EventArgs e)
        {
            anasayfa kapat=new anasayfa();
            kapat.Close();
            UyeIslemleri uye = new UyeIslemleri();
            uye.Show();
            Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            anasayfa kapat = new anasayfa();
            kapat.Close();
            Hide();
            Kitapİslemleri ac=new Kitapİslemleri(); 
            ac.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa kapat = new anasayfa();
            kapat.Close();
            Hide();
            EmanetKitapİsleri ac = new EmanetKitapİsleri();
            ac.Show();
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
