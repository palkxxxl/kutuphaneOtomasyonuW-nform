using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonuWınform.Kullanici
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanıcı_ad = KullaniciAdıTxt.Text;
            kullanicilar.kullanıcı_soyad = KullaniciSoyadTxt.Text;
            kullanicilar.kullanici_tc = KullanıcıTcTxt.Text;
            kullanicilar.kullanici_mail = KullaniciMailTxt.Text;
            kullanicilar.kullanici_tel = KullaniciTelTxt.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble( KullaniciCezaTxt.Text);
            if(radioButtonE.Checked==true)

                {
                kullanicilar.kullanici_cinsiyet = ("E");
            }
            else if(radioButtonK.Checked==true)
            {
                kullanicilar.kullanici_cinsiyet= ("K");
            }
           // else
            //{
              //  MessageBox.Show("Lütfen Cinsiyet Belirtiniz.");
            //}
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }
    }
}
