using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotatkiApp
{
    internal class Program
    {
        class Notatka
        {
            private static int licznik;
            private int id;
            private string tytul;
            private string tresc;

            public Notatka(string tytul, string tresc)
            {
                licznik++;
                id = licznik;
                this.tytul = tytul;
                this.tresc = tresc;
            }

            public void Wyswietl()
            {
                Console.WriteLine("Tytul: " + tytul);
                Console.WriteLine("Tresc: " + tresc);
                Console.WriteLine(" ");
            }

            public void PokazSzczegoly()
            {
                Console.WriteLine("ID: " + id + ", Tytul: " + tytul + ", Tresc: " + tresc);
                Console.WriteLine(" ");
            }
        }

        static void Main(string[] args)
        {
            var notatka1 = new Notatka("Pranie", "Zrobic pranie o 18:00");
            notatka1.Wyswietl();
            notatka1.PokazSzczegoly();

            var notatka2 = new Notatka("Nauka", "Nauczyc sie C# na jutro");
            notatka2.Wyswietl();
            notatka2.PokazSzczegoly();
        }
    }
}

