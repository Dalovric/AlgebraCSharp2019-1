namespace Zad3
{
    internal class Automobil
    {
        // Polja
        public string Naziv = "";
        public int GodinaProizvodnje = 0;
        public double OsnovnaCijena = 0;

        // Metode

        double faktor = 1;

        public double UkupnaCijena()
        {
            if (OsnovnaCijena <= 70000)
            {
                faktor = 1.3;
            }
           
        else if (OsnovnaCijena > 70000 && OsnovnaCijena< 100000)
            { 
                faktor = 1.4;
            }
        else
            {
                faktor = 1.5;
            }
            return OsnovnaCijena * faktor;



        }
}