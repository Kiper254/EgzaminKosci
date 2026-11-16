using System;

namespace Wspolne
{
    public static class LogikaGry
    {
        public static int[] LosujKosci(int liczbaKostek, Random generator)
        {
            int[] wyniki = new int[liczbaKostek];

            for (int indeks = 0; indeks < wyniki.Length; indeks++)
            {
                wyniki[indeks] = generator.Next(1, 7);
            }

            return wyniki;
        }

        /*
        ****************************************
        nazwa: ObliczPunkty
        opis: Oblicza sume oczek dla wartosci wystepujacych co najmniej dwa razy.
        parametry: wyniki - tablica wynikow rzutu kostkami
        zwracany typ i opis: int - liczba punktow uzyskanych w rzucie
        autor: numer zdajacego
        ****************************************
        */
        public static int ObliczPunkty(int[] wyniki)
        {
            int[] liczbaWystapien = new int[7];

            for (int indeks = 0; indeks < wyniki.Length; indeks++)
            {
                liczbaWystapien[wyniki[indeks]]++;
            }

            int punkty = 0;

            for (int oczka = 1; oczka <= 6; oczka++)
            {
                if (liczbaWystapien[oczka] >= 2)
                {
                    punkty += oczka * liczbaWystapien[oczka];
                }
            }

            return punkty;
        }
    }
}