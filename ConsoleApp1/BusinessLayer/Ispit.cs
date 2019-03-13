namespace BusinessLayer
{
    public class Ispit
    {
        private string naziv = "Matematika";
        private object engleski;

        public Ispit(string v)
        {
            this.Naziv = v;
        }

        public string Naziv { get => naziv; set => naziv = value; }
    }
}