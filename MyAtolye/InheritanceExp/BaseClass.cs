namespace InheritanceExp
{
    public class BaseClass
    {
        private string _sekilTipi;
        public string SekilTipi
        {
            get
            {
                return _sekilTipi;
            }

            set
            {
                _sekilTipi = value;
            }
        }

        public BaseClass()
        {
            _sekilTipi = "Kare";
        }

        public BaseClass(string tip)
        {
            _sekilTipi = tip;
        }

        public string SekilTipiYaz()
        {
            return $"Bu nesnemiz {_sekilTipi.ToString()} tipindedir";
        }
    }
}
