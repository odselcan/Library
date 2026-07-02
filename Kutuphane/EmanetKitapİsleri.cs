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
    public partial class EmanetKitapİsleri : Form
    {
        public EmanetKitapİsleri()
        {
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            EmanetKitapİsleri kapat = new EmanetKitapİsleri();
            kapat.Close();
            Hide();
            EmanetKitapVerme ac = new EmanetKitapVerme();
            ac.Show();
        }
        private void geribtn_Click(object sender, EventArgs e)
        {
            EmanetKitapİsleri kapat = new EmanetKitapİsleri();
            kapat.Close();
            Hide();
            anasayfa ac = new anasayfa();
            ac.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EmanetKitapİsleri kapat = new EmanetKitapİsleri();
            kapat.Close();
            Hide();
            EmanetKitapTeslim ac = new EmanetKitapTeslim();
            ac.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EmanetKitapİsleri kapat = new EmanetKitapİsleri();
            kapat.Close();
            Hide();
            EmanetKitapListesi ac = new EmanetKitapListesi();
            ac.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        private void EmanetKitapİsleri_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
