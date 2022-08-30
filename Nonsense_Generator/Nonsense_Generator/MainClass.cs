using System;
using System.Net;
public class MainClass
{
    static int lauseLkm;
    static bool play = true;
    static void Main(string[] args)
    {
        Sanataulu substantiivit = new Sanataulu();
        Sanataulu verbit = new Sanataulu();
        Generaattori generaattori;
        while (play)
        {
            Console.WriteLine("**** Tervetuloa puppulausegeneraattoriin ****");
            lauseLkm = InputInt();
            Console.WriteLine("Syötä 5 substantiivia");
            substantiivit.Tayta();

            Console.WriteLine("Syötä 5 verbiä (yksikön 3. persoona)");
            verbit.Tayta();

            generaattori = new Generaattori(lauseLkm, substantiivit.GetTaulu(), verbit.GetTaulu());
            generaattori.Generoi();

            loppu(generaattori);
        }
        /**
             * Metodi vastaanottaa kokonaisluvun konsolista, muuttaa sen int32:ksi ja palauttaa pääohjelmaan.
             */
        static int InputInt()
        {
            int i = 0;
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.Write("Lauseiden lukumäärä >");
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i > 0)
                    {
                        stop = true;
                    }
                    else
                    {
                        Console.WriteLine("Jos nyt ees yks lause tehtäis...");
                        //continue;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ei ollut numero. Yritäppä uudestaan.");
                }
            }
            return i;
        }

        /*
         * Metodi kysyy käyttäjältä, haluaako hän generoida uudet lauseet. Jos ei, käyttäjältä kysytään, haluaako hän tallentaa viimeisimät lauseet tiedostoon.
         * Jos kyllä, käyttäjä syöttää tiedoston nimen
         * Jos ei, ohjelma sulkeutuu
         */
        static void loppu(Generaattori generaattori)
        {
            char c = 'c';

            while (!c.Equals('k') && !c.Equals('e'))
            {
                Console.Write("Generoidaanko uudet lauseet? (k/e) >");
                c = Console.ReadLine()[0];
                if (c == 'k')
                {
                    break;
                }
                if (c == 'e')
                {
                    Console.Write("Tallennetaanko lauseet tiedostoon? (k/e) >");
                    char y = Console.ReadLine()[0];
                    if (y.Equals('k'))
                    {
                        generaattori.makeFile();
                    }
                    play = false;
                }
            }

        }
    }
}


