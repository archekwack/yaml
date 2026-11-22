using System;

class Program
{
    static void Main()
    {
        // Pobieranie wysokości od użytkownika
        Console.Write("Podaj wysokość choinki (od 2 do 10): ");
        if (int.TryParse(Console.ReadLine(), out int wysokosc))
        {
            // Sprawdzenie, czy wysokość mieści się w przedziale 2-10
            if (wysokosc >= 2 && wysokosc <= 10)
            {
                // Rysowanie korony choinki
                for (int i = 0; i < wysokosc; i++)
                {
                    // 1. Pętla rysująca spacje (wyśrodkowanie)
                    for (int j = 0; j < wysokosc - i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    // 2. Pętla rysująca gwiazdki (nieparzysta liczba: 1, 3, 5...)
                    for (int k = 0; k < (2 * i + 1); k++)
                    {
                        Console.Write("*");
                    }

                    // Przejście do nowego wiersza
                    Console.WriteLine();
                }

                // Rysowanie pnia (wyśrodkowana pojedyncza gwiazdka)
                for (int j = 0; j < wysokosc - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine("Podana wysokość jest poza zakresem 2-10.");
            }
        }
        else
        {
            Console.WriteLine("Wprowadzono niepoprawną liczbę.");
        }
    }
}