// SZFT5 LáBiKo
// Kovács Ádám Attila, Birovits Bence, Lázár Boldizsár, Szomor Levente, Nagy-Erdei Móric

using System;

class Program
{
    static char[,] palya;
    static int palyaMeret = 15; // Növeltük a pálya méretét
    static int jatekosX, jatekosY;

    static void Main()
    {
        //Inicializalas();   Birovits feladat
        //KirajzolPalya();   Birovits feladat

        while (true)
        {
            Kezeles(Console.ReadKey(true).Key);
            //KirajzolPalya();   Birovits feladat
        }
    }

    




    static void Kezeles(ConsoleKey key)
    {
        // Játékos mozgatása mindenhova    Lázár feladat
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (jatekosX > 1)
                {
                    Mozgas(-1, 0);
                }
                break;

            case ConsoleKey.DownArrow:
                if (jatekosX < palyaMeret - 2)
                {
                    Mozgas(1, 0);
                }
                break;

            case ConsoleKey.LeftArrow:
                if (jatekosY > 1)
                {
                    Mozgas(0, -1);
                }
                break;

            case ConsoleKey.RightArrow:
                if (jatekosY < palyaMeret - 2)
                {
                    Mozgas(0, 1);
                }
                break;
        }
    }

    static void Mozgas(int dx, int dy)
    {
        // Játékos mozgatása csak üres területekre vagy tárgyakra  Lázár feladat
        if (palya[jatekosX + dx, jatekosY + dy] != 'E' && palya[jatekosX + dx, jatekosY + dy] != 'X')
        {
            palya[jatekosX, jatekosY] = ' ';
            jatekosX += dx;
            jatekosY += dy;
            palya[jatekosX, jatekosY] = 'P';
        }
    }
}
