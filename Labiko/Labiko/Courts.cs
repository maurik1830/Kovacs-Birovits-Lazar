using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBiKo
{
    internal class Palya1
    {
        private int szoba1mag;
        private int szoba1szel;

        private int szoba2mag;
        private int szoba2szel;

        private int szoba3mag;
        private int szoba3szel;

        private int szoba4mag;
        private int szoba4szel;


        public int Szoba1Ter
        {
            get { return szoba1mag * szoba1szel; }
            init { }

        }



        public int Szoba2Ter
        {
            get { return szoba2mag * szoba2szel; }
            init { }

        }


        public int Szoba3Ter
        {
            get { return szoba3mag * szoba3szel; }
            init { }

        }



        public int Szoba4Ter
        {
            get { return szoba4mag * szoba4szel; }
            init { }

        }

        public Palya1(int[] szoba1, int[] szoba2, int[] szoba3, int[] szoba4)
        {

            szoba1mag = szoba1[0];
            szoba1szel = szoba1[1];


            szoba2mag = szoba2[0];
            szoba2szel = szoba2[1];


            szoba3mag = szoba3[0];
            szoba3szel = szoba3[1];



            szoba4mag = szoba4[0];
            szoba4szel = szoba4[1];


        }




    }
}
