namespace NotatkiKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notatka n1 = new Notatka("Zakupy", "Kupić chleb i mleko");
            Notatka n2 = new Notatka("Szkoła", "Zrobić zadanie z programowania");

            Console.WriteLine("--- Pierwsza notatka ---");
            n1.WyswietlNotatke();
            Console.Write("Diagnostyka: ");
            n1.WyswietlDiagnostyke();

            Console.WriteLine("\n--- Druga notatka ---");
            n2.WyswietlNotatke();
            Console.Write("Diagnostyka: ");
            n2.WyswietlDiagnostyke();
        }
    }
}