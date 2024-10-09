using System;

class Program
{
    static void Main(string[] args)
    {
    
        Zmienne();
    
        wyswietlanieZmiennejChar();
    
        wyswietlZmienne();

        program();

        petle();

        choinka();
    
    }
        
        void Zmienne()
        {
        //1. Definiowanie po 1 zmiennej kazdego typu
        int liczba = 10;

        float liczbaZmiennoprzecinkowa = 10.5f;

        string tekst = "Witaj";

        char znak = 'A';

        char[] tablicaZnakow = { 'A', 'B', 'C' };
        }

        //2a. wyœwietlenie zmiennej char za pomoc¹ pêtli foreach
        void wyswietlanieZmiennejChar()
        {
        foreach (char znak in tablicaZnakow)
        {
            Console.WriteLine(znak + " "); 
        }
        }

        //2b. wyswietlenie kazdej zmiennej z zadania 1
        int wyswietlZmienne()
        {
            Console.WriteLine($"zmienna int: {liczba}");
            Console.WriteLine($"zmienna float: {liczbaZmiennoPrzecinkowa}");
            Console.WriteLine($"zmienna string: {tekst}");
            Console.WriteLine($"zmienna char: {znak}");
        }

        //3/4. program pobieraj¹cy dane od uzytkownika.
        string program()
        {
                
            Console.Write("Podaj swoje imie: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj swoj wiek: ");
            int wiek;
            bool czyWiekPoprawny = int.TryParse(Console.ReadLine(), out wiek);

            Console.Write("Podaj rok urodzenia: ");
            int rokUrodzenia;
            bool czyRokPoprawny = int.TryParse(Console.ReadLine(), out rokUrodzenia);

            Console.Write("Podaj plec (m lub k): ");
            string plec = Console.ReadLine();

            bool Blad = false;

            if (!czyWiekPoprawny || wiek <= 0 || wiek > 120)
            {
                Console.WriteLine("Wiek jest bledny.");
                Blad = true;
            }

            if (!czyRokPoprawny || rokUrodzenia > 2010)
            {
                Console.WriteLine("Rok urodzenia jest wiêkszy niz 2010.");
                Blad = true;
            }

            if (plec.ToLower() != "m" && plec.ToLower() != "k")
            {
                Console.WriteLine("Blad: Plec moze byc tylko 'm' lub 'k'.");
                Blad = true;
            }

            if (!Blad)
            {
                Console.WriteLine("\nDane uzytkownika:");
                Console.WriteLine($"Imie: {imie}");
                Console.WriteLine($"Wiek: {wiek}");
                Console.WriteLine($"Rok urodzenia: {rokUrodzenia}");
                Console.WriteLine($"Plec: {plec}");
        }

        //5. jedna pêtla ka¿dego rodzju
        void petle()
        {
            char[] For = { 'A', 'B', 'C', 'D' };
            char[] Foreach = { 'A', 'B', 'C', 'D' };
            int While = 15;
            int DoWhile = 10;

            //pêtla for
            for (int i = 0; i < For.Length; i++)
            {
                Console.WriteLine(znakiFor[i] + " ");
            }

            //pêtla foreach
            foreach (char znak in Foreach)
            {
                Console.WriteLine(znak + " ");
            }

            //petla while
            int j = 0;
            while (j < While.Length)
            {
                Console.WriteLine(While[j] + " ");
                j++;
            }
            
            //pêtla dowhile
            int k = 0;
            do
            {
                Console.WriteLine(DoWhile[k] + " ");
                k++;
            } while (k < DoWhile.Length);

            //5d. podwójna choinka za pomoca petli for
            void choinka()
            {
                Console.Write("Wpisz rozmiar choinki: ");
                int rozmiar;
                bool poprawnyRozmiar = int.TryParse(Console.ReadLine(), out rozmiar);

                if (!poprawnyRozmiar || rozmiar <= 0)
                {
                    Console.WriteLine("Liczba musi być większa od 0.");
                    return;
                }

                for (int i = 1; i <= rozmiar; i++)
                {
                    for (int j = 1; j <= rozmiar - i; j++)
                    {
                        Console.Write(" ");
                    }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
}                    




