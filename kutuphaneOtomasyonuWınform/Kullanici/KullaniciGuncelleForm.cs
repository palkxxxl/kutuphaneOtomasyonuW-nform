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
    public partial class KullaniciGuncelleForm : Form
    {
        public KullaniciGuncelleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public void Listele()

        {

            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KullaniciAdıTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            KullaniciSoyadTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            KullanıcıTcTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            KullaniciMailTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            KullaniciTelTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            KullaniciCezaTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();        
            

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
                radioButtonE.Checked = true;
            else
                radioButtonK.Checked = true;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici=db.Kullanicilar.Where(x=>x.kullanici_id == secilenId).FirstOrDefault();
            kullanici.kullanıcı_ad = KullaniciAdıTxt.Text;
            kullanici.kullanıcı_soyad = KullaniciSoyadTxt.Text;
            kullanici.kullanici_tc = KullanıcıTcTxt.Text;
            kullanici.kullanici_mail = KullaniciMailTxt.Text;
            kullanici.kullanici_tel = KullaniciTelTxt.Text;
            kullanici.kullanici_ceza = Convert.ToDouble(KullaniciCezaTxt.Text);
            if (radioButtonE.Checked == true)

            {
                kullanici.kullanici_cinsiyet = ("E");
            }
            else if (radioButtonK.Checked == true)
            {
                kullanici.kullanici_cinsiyet = ("K");
            }
            db.SaveChanges();
            Listele();
        }
    }
}
