using System;
using System.Collections;
using System.Windows.Forms;

namespace HashTableExpForm
{
    public partial class Form1 : Form
    {
        Hashtable htTeknikSozluk;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            htTeknikSozluk = new Hashtable();
            stbDurum.Text = htTeknikSozluk.Count.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                htTeknikSozluk.Add(txtKey.Text, txtValue.Text);
                listBox1.Items.Add(txtKey.Text);

                stbDurum.Text = htTeknikSozluk.Count.ToString();
            }
            catch (ArgumentException)
            {
                stbDurum.Text = txtKey.Text + " Zaten HashTable Koleksiyonunda Mevcut!";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string deger;
            deger = htTeknikSozluk[listBox1.SelectedItem.ToString()].ToString();
            MessageBox.Show(deger, listBox1.SelectedItem.ToString());
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            if (htTeknikSozluk.Count == 0)
            {
                stbDurum.Text = "Çıkartılabilecek hiç bir eleman yok";
            }
            else if (listBox1.SelectedIndex == -1)
            {
                stbDurum.Text = "Listeden bir eleman seçmelisiniz";
            }
            else
            {
                htTeknikSozluk.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
                stbDurum.Text = "Çıkartıldı";
                stbDurum.Text = htTeknikSozluk.Count.ToString();
            }
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ICollection anahtar = htTeknikSozluk.Keys;
            foreach (string item in anahtar)
            {
                listBox2.Items.Add(item + "=" + htTeknikSozluk[item].ToString());
            }
        }
    }
}
