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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            EkleKullaniciBtn.Visible = false;
            GucelleKullanıcıBtn.Visible = false;
            SilKullanıcıBtn.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EkleKullaniciBtn.Visible == false)
            {

                EkleKullaniciBtn.Visible = true;
                GucelleKullanıcıBtn.Visible = true;
                SilKullanıcıBtn.Visible = true;
            }
            else
            {
                EkleKullaniciBtn.Visible = false;
                GucelleKullanıcıBtn.Visible = false;
                SilKullanıcıBtn.Visible = false;
            }


            KullaniciListeForm kListeForm=new KullaniciListeForm();
            kListeForm.MdiParent = this;
            kListeForm.Show();
             

        }

            }
}
