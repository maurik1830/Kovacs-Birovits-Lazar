using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBiKo
{
    internal class Palya1
    {

        private int Szoba1Mag;
        private int Szoba1Szel;


        private int Szoba2Mag;
        private int Szoba2Szel;

        private int Szoba3Mag;
        private int Szoba3Szel;

        private int Szoba4Mag;
        private int Szoba4Szel;


        public int Szoba1Ter
        {
            get { return Szoba1Mag* Szoba1Szel; }
            init { }

        }



        public int Szoba2Ter
        {
            get { return Szoba2Mag* Szoba2Szel; }
            init { }

        }


        public int Szoba3Ter
        {
            get { return Szoba3Mag * Szoba3Szel; }
            init { }

        }



        public int Szoba4Ter
        {
            get { return Szoba4Mag * Szoba4Szel; }
            init { }

        }

        public Palya1(int[] szoba1, int[] szoba2, int[] szoba3, int[] szoba4)
        {

            Szoba1Mag= szoba1[0];
            Szoba1Szel = szoba1[1];


            Szoba2Mag = szoba2[0];
            Szoba2Szel = szoba2[1];


            Szoba3Mag = szoba3[0];
            Szoba3Szel = szoba3[1];



            Szoba4Mag = szoba4[0];
            Szoba4Szel = szoba4[1];


        }

        public void Szoba1WR()
        {




            char[,] szoba_1 = new char[Szoba1Mag, Szoba1Szel];
            int jatekosX = Szoba1Mag / 2;
            int jatekosY = Szoba1Szel / 2;

            // Pálya feltöltése falakkal és üres területekkel // Lázár feladat
            for (int i = 0; i < Szoba1Mag; i++)
            {
                for (int j = 0; j < Szoba1Szel; j++)
                {
                    // Falak a pálya szélén
                    if (i == 0 || j == 0 || i == Szoba1Mag- 1 || j == Szoba1Szel- 1)
                    {
                        szoba_1[i, j] = 'X';
                    }
                    else if (j == 10)
                    {
                        szoba_1[i, j] = 'A';
                    }

                    else
                    {
                        szoba_1[i, j] = '.';
                    }
                }
            }

            // Játékos elhelyezése a pálya közepén
            szoba_1[jatekosX, jatekosY] = 'P';

            // Tárgyak és élőlények elhelyezése
            Random rand = new Random();
            int targyakSzama = 8;
            int elolenyekSzama = 5;

            for (int i = 0; i < targyakSzama; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(1, Szoba1Mag - 1);
                    y = rand.Next(1, Szoba1Szel - 1);
                } while (szoba_1[x, y] != '.');

                szoba_1[x, y] = 'T';
            }

            for (int i = 0; i < elolenyekSzama; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(1, Szoba1Mag - 1);
                    y = rand.Next(1, Szoba1Szel - 1);
                } while (szoba_1[x, y] != '.');

                szoba_1[x, y] = 'E';
            }
        }




    }
}
