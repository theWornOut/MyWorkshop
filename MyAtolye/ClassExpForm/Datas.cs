using System;
using System.Data.SqlClient;

namespace ClassExpForm
{
    public class Datas
    {
        private string _sunucuAdi;
        private string _veritabaniAdi;
        private string _kullanici;
        private string _parola;
        private SqlConnection _conn;
        private bool _baglantiDurumu;
        private string _hataDurumu;

        public string SunucuAdi
        {
            get
            {
                return _sunucuAdi;
            }

            set
            {
                _sunucuAdi = value;
            }
        }

        public string VeritabaniAdi
        {
            get
            {
                return _veritabaniAdi;
            }

            set
            {
                _veritabaniAdi = value;
            }
        }

        public string Kullanici
        {
            get
            {
                return _kullanici;
            }

            set
            {
                _kullanici = value;
            }
        }

        public string Parola
        {
            get
            {
                return _parola;
            }

            set
            {
                _parola = value;
            }
        }

        public SqlConnection Conn
        {
            get
            {
                return _conn;
            }

            set
            {
                _conn = value;
            }
        }

        public bool BaglantiDurumu
        {
            get
            {
                return _baglantiDurumu;
            }

            set
            {
                _baglantiDurumu = value;
                if (value == true)
                {
                    BaglantiAc();
                }
                else
                {
                    BaglantiKapat();
                }
            }
        }

        public string HataDurumu
        {
            get
            {
                return _hataDurumu;
            }
            set
            {
                _hataDurumu = value;
            }
        }

        public Datas()
        {

        }

        public Datas(string sunucuAdi, string veritabaniAdi, string kullaniciAdi, string sifre)
        {
            _sunucuAdi = SunucuAdi;
            _veritabaniAdi = veritabaniAdi;
            _kullanici = kullaniciAdi;
            _parola = sifre;
            Baglan();
        }

        private void Baglan()
        {
            SqlConnection conn = new SqlConnection("data source =" + _sunucuAdi + ";initial catalog=" + _veritabaniAdi + ";user id=" + _kullanici + ";password=" + _parola);
            _conn = conn;
        }

        private void BaglantiAc()
        {
            _conn.Open();
            try
            {
                _baglantiDurumu = true;
                _hataDurumu = "Baglanti saglandi";
            }
            catch (Exception ex)
            {
                _hataDurumu = "Baglanti saglanamadi.\n" + ex.Message.ToString();
            }
        }

        private void BaglantiKapat()
        {
            _conn.Close();
            _baglantiDurumu = false;
        }
    }
}
