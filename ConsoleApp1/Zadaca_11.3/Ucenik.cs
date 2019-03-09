namespace Zadaca_11._3
{
    internal class Ucenik
    {
        private string ime = "";
        private string prezime = "";
        private long oib = 0;
        public string telefon = "";
        private long racun = 0;

        public string Ime { get => ime; }

        public string Prezime { get => prezime;}

        public long Oib { set => oib = value; }

        public long Racun { get => racun; set => racun = value; }

        public override string ToString()
        {
            string poruka = string.Format("pozdrav {0} {1} {2}", ime, prezime, racun);
            return poruka;
        }

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.racun = 3000;
        }

        public Ucenik(string ime, string prezime, long oib) : this(ime, prezime)
        {
            this.oib = oib;
            this.racun = 4000;
        }

        public Ucenik(string ime, string prezime, long oib, long racun) : this(ime, prezime, oib)
        {
            this.racun = racun;
        }
    }
}