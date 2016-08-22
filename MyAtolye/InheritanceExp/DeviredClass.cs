namespace InheritanceExp
{
    public class DeviredClass : BaseClass
    {
        private bool _alan;
        private bool _cevre;
        private int _taban;
        private int _yukseklik;
        private int _ucuncuKenar;
        private bool _kare;
        private bool _dikdortgen;
        private bool _ucgen;

        public bool Alan
        {
            get
            {
                return _alan;
            }
        }

        public bool Cevre
        {
            get
            {
                return _cevre;
            }
        }

        public int Taban
        {
            get
            {
                return _taban;
            }
        }

        public int Yukseklik
        {
            get
            {
                return _yukseklik;
            }
        }

        public int UcuncuKenar
        {
            get
            {
                return _ucuncuKenar;
            }
        }

        public bool Kare
        {
            get
            {
                return _kare;
            }

            set
            {
                _kare = value;
            }
        }

        public bool Dikdortgen
        {
            get
            {
                return _dikdortgen;
            }

            set
            {
                _dikdortgen = value;
            }
        }

        public bool Ucgen
        {
            get
            {
                return _ucgen;
            }

            set
            {
                _ucgen = value;
            }
        }

        public DeviredClass()
        {

        }

        public DeviredClass(string tip, bool alan, bool cevre, int taban, int yukseklik, int ucuncuKenar) : base(tip)
        {
            _alan = alan;
            _cevre = cevre;
            _taban = taban;
            _yukseklik = yukseklik;
            _ucuncuKenar = ucuncuKenar;
        }

        public double AlanBul()
        {
            return Ucgen == Ucgen ? (_taban * _yukseklik) / 2 : 0;
        }

        public double CevreBul()
        {
            return Kare == Kare ? _taban * 4 : 0;
        }

        public new string SekilTipiYaz()
        {
            return "ucgen";
        }
    }
}
