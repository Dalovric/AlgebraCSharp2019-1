using System;

namespace _8._1._1_proizvod
{
    internal class Proizvod
    {
        //Polja
        public string Naziv = "";
        public double Cijena = 0;
        public double Marza = 0;
        public double Porez = 0;
        private string v;

        public Proizvod(string naziv)
        {
            Naziv = naziv;
        }

        public double MPC()
        {
            return Cijena + Marza + Porez;
        }
    }
}