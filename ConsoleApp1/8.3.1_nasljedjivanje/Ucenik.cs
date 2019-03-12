using _8._1._2_Prirucnik;
using System;
namespace _8._3._1_nasljedjivanje
{
    internal class Ucenik : Osoba, IUcenik
    {
        // private string ime = "";
        // public DateTime datumNastanka;
        // public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;
        private Ispit prijavljeniIspit;

        // public string Ime { get => ime; set => ime = ToUpper.FirstCharToUpper(value); }


        // ovaj radi samo kod direktnog poziva
        // Ucenik u99 = new Ucenik();
        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Ucenik:Osoba()");
        }

        public Ucenik(string v):base()
        {
            this.Ime = v;
        }
        public Ucenik(string v, string prez):this (v)
        {
            // this.Ime = v;
            this.prezime = prez;
        }

        public void PrijaviIspit(Ispit ispit)
        {
            this.prijavljeniIspit = ispit;
            Console.WriteLine("Uspjesno ste prijavili ispit " + this.prijavljeniIspit.Naziv);
        }

        public double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(ocjenaIzBiologije + ocjenaIzEngleskog + ocjenaIzMatematike) / 3;
            // throw new NotImplementedException();

            return prosjek;
        }
        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je:" + this.Prosjek()+" ja sam tipa "+this.GetType();
        }
    }
}