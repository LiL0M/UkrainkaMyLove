using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            Console.WriteLine("Wybierz figiure, ktora chcesz narysowac:");
            Console.WriteLine("1 - Trojkat, 2 - Prostokat, 3 - Kolo");

            while (loop)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Trojkat tr1 = new Trojkat(1, 2, 5);
                        Trojkat tr2 = new Trojkat(tr1);
                        int j = 5;
                        tr1.Tojkat(out j);
                        break;

                        

                    case '2':
                        Console.Clear();
                        Prostokat pro = new Prostokat();
                        int x = 40;
                        pro.Protokat(ref x);
                        break;

                    case '3':




                        break;

                    case 'x':
                        loop = false;
                        break;
                        
                }
            }

        }
    }

    class Trojkat
    {

        private float _j { get; set; }
        internal float _m;
        protected float _n;

        public float wlasciwosciTrojkat
        {
            get { return _j; }
            set { _j = value; }
        }

        //konstruktor

        public Trojkat(int j, int m, int n)
        {
            _j = j;
            _m = m;
            _n = n;
        }

        //konstruktor kopiujacy

        public Trojkat(Trojkat trojkat)
        {
            _j = trojkat._j;
            _m = trojkat._m;
            _n = trojkat._n;
        }

        //przekazywanie przez wyjscie

        public void Tojkat(out int j)
        {
            j = 10;

            for (int i = 1; i <= j; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }

    }

    class Prostokat
    {
        //Kontruktor domyslny
        public Prostokat()
        {

        }

        //Referencja
        public void Protokat(ref int x)
        {
            x = 20;

            for (int i = 0; i <= x / 4; i++)
            {
                for (int j = 0; j <= x; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
    }

}
