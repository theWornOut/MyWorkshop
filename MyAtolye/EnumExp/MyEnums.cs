namespace EnumExp
{
    public class MyEnums
    {
        public enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        public enum Meslekler
        {
            Memur = 15,
            Isci = 10,
            Muhendis = 30,
            Doktor = 35,
            Asker = 50
        }

        public enum MinMax : long
        {
            Max = 115231234L,
            Min = 255L
        }

        public enum AlanKodu
        {
            Anadolu = 216,
            Avrupa = 212,
            Ankara = 312,
            Izmir = 412
        }
    }
}
