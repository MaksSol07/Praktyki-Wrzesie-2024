using System;

class Program
{
    static void Main(string[] args)
    {
        void Zmienne()
        {
        //1. Definiowanie po 1 zmiennej ka�dego typu
        int liczba = 10;

        float liczbaZmiennoprzecinkowa = 10.5f;

        string tekst = "Witaj";

        char znak = 'A';

        char[] tablicaZnakow = { 'A', 'B', 'C' };
        }

        //2a. wy�wietlenie zmiennej char za pomoc� p�tli foreach
        void wy�wietlanieZmiennejChar()
        {
        foreach (char znak in tablicaZnakow)
        {
            Console.WriteLine(znak + " "); 
        }
        }

        //2b. wy�wietlenie ka�dej zmiennej z zadania 1
        int wyswietlZmienne()
        {
            Console.WriteLine($"zmienna int: {liczba}");
            Console.WriteLine($"zmienna float: {liczbaZmiennoPrzecinkowa}");
            Console.WriteLine($"zmienna string: {tekst}");
            Console.WriteLine($"zmienna char: {znak}");
        }

        //3/4. program pobieraj�cy dane od u�ytkownika.
        string program()
        {
                
            Console.Write("Podaj swoje imi�: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj sw�j wiek: ");
            int wiek;
            bool czyWiekPoprawny = int.TryParse(Console.ReadLine(), out wiek);

            Console.Write("Podaj rok urodzenia: ");
            int rokUrodzenia;
            bool czyRokPoprawny = int.TryParse(Console.ReadLine(), out rokUrodzenia);

            Console.Write("Podaj p�e� (m lub k): ");
            string plec = Console.ReadLine();

            bool Blad = false;

            if (!czyWiekPoprawny || wiek <= 0 || wiek > 120)
            {
                Console.WriteLine("B��d: Wiek jest b��dny.");
                Blad = true;
            }

            if (!czyRokPoprawny || rokUrodzenia > 2010)
            {
                Console.WriteLine("B��d: Rok urodzenia jest wi�kszy ni� 2010.");
                Blad = true;
            }

            if (plec.ToLower() != "m" && plec.ToLower() != "k")
            {
                Console.WriteLine("B��d: P�e� mo�e by� tylko 'M' lub 'K'.");
                Blad = true;
            }

            if (!Blad)
            {
                Console.WriteLine("\nDane u�ytkownika:");
                Console.WriteLine($"Imi�: {imie}");
                Console.WriteLine($"Wiek: {wiek}");
                Console.WriteLine($"Rok urodzenia: {rokUrodzenia}");
                Console.WriteLine($"P�e�: {plec}");
        }

        //5. jedna p�tla ka�dego rodzju
        void petle()
        {
            char[] For = { 'A', 'B', 'C', 'D' };
            char[] Foreach = { 'A', 'B', 'C', 'D' };
            int While = 15;
            int DoWhile = 10;

            //p�tla for
            for (int i = 0; i < For.Length; i++)
            {
                Console.WriteLine(znakiFor[i] + " ");
            }

            //p�tla foreach
            foreach (char znak in Foreach)
            {
                Console.WriteLine(znak + " ");
            }

            //p�tla while
            int j = 0;
            while (j < While.Length)
            {
                Console.WriteLine(While[j] + " ");
                j++;
            }
            
            //p�tla dowhile
            int k = 0;
            do
            {
                Console.WriteLine(DoWhile[k] + " ");
                k++;
            } while (k < DoWhile.Length);

            //5d. podw�jna choinka za pomoc� p�tli for
            function choinka()
            {
                Console.Write("Podaj rozmiar choinki: ");
                int rozmiar;
                bool poprawnyRozmiar = int.TryParse(Console.ReadLine(), out rozmiar);

                if (!poprawnyRozmiar || rozmiar <= 0)
                {
                    Console.WriteLine("Nieprawid�owy rozmiar. Podaj liczb� wi�ksz� ni� 0.");
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
            }
        }
    }
}


