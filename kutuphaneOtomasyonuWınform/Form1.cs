using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonuWınform
{
    public partial class Form1 : Form
        
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Personelgırısbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = personelgırıstxt.Text;
            string gelenSifre = sıfregırıstxt.Text;
            //linq sorgusu
            var personel = db.Personeller.Where(x => x.personel_kullaniciAd.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();
            if(personel == null)
            {
                MessageBox.Show(text: " Kullanıcı Adı Veya Şifre Hatalı");
            }
            else
            {
                MessageBox.Show(text: "Başarılı");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }

           
            
        }
        
    }
    
}
