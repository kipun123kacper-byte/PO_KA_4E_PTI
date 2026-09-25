namespace NotatkiKonsola
{
    public class Notatka
    {
        private static int licznikNotatek = 0;
        private int id;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznikNotatek++;
            this.id = licznikNotatek;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void WyswietlNotatke()
        {
            Console.WriteLine("Tytuł: " + this.tytul);
            Console.WriteLine("Treść: " + this.tresc);
        }

        public void WyswietlDiagnostyke()
        {
            Console.WriteLine(this.id + ";" + this.tytul + ";" + this.tresc + ";" + licznikNotatek);
        }
    }
}