namespace _8._1._2_Prirucnik
{
    internal class Nastavnik
    {

        private string ime = "Antonije Marcus";

        private int oib;


        // write only
        public int Oib
        {
            
            set => oib = value;
        }

        public int PartialOib
        {

            get => int.Parse(oib.ToString().Substring(0,3));
        }

        // readonly
        public string Ime
        {
            get => ime;
            
        }

        public static string Opis()
        {
            return "Nastavnik je osoba koja predaje u obrazovnim ustanovama";
            
        }

        /// <summary>
        /// Ovo dohvaca koef za izracun place
        /// </summary>
        /// <returns>float</returns>
        public static float Koeficijent()
        {
            return 1.5f;
        }

        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj oib je:" + this.PartialOib+"********";
        }
    }
}