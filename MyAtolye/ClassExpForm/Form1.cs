using System;
using System.Windows.Forms;

namespace ClassExpForm
{
    public partial class Form1 : Form
    {
        Datas db;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            db = new Datas(txtSunucu.Text, txtVeritabani.Text, txtKullanici.Text, txtParola.Text);
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            db.BaglantiDurumu = true;
            lblDurum.Text = "Sunucu Bağlantı Durumu: " + db.BaglantiDurumu.ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            db.BaglantiDurumu = false;
            lblDurum.Text = "Sunucu Bağlantı Durumu: " + db.BaglantiDurumu.ToString();
        }
    }
}
