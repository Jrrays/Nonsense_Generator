using System.Collections.ObjectModel;

public class Generaattori
{
    private String[] substantiivit;
    private String[] verbit;
    private int lkm;
    private List<String> lauseet;

    public Generaattori(int lkm, String[] subs, String[] verb)
    {
        this.lkm = lkm;
        substantiivit = subs;
        verbit = verb;
        lauseet = new List<string>();
    }

    public void Generoi()
    {
        int counter = 0;
        int i;
        int x = 5;
        Random rnd = new Random();

        Console.WriteLine("**** Puppulauseet ****");
        do
        {
            i = rnd.Next(6);
            switch (i)
            {
                case 0:
                    lauseet.Add("Jos " + substantiivit[rnd.Next(x)] + " " + verbit[rnd.Next(x)] + ", niin " + substantiivit[rnd.Next(x)] + " " + verbit[rnd.Next(x)] + ".");
                    //Console.WriteLine("Jos " + substantiivit[rnd.Next(5)] + " " + verbit[rnd.Next(4)] + ", niin " + substantiivit[rnd.Next(4)] + " " + verbit[rnd.Next(5)] + ".");
                    counter++;
                    break;
                case 1:
                    lauseet.Add((Capitalize(substantiivit[rnd.Next(x)]) + " " + verbit[rnd.Next(x)] + " ja " + substantiivit[rnd.Next(x)] + " " + verbit[rnd.Next(x)] + "."));
                    //Console.WriteLine(Capitalize(substantiivit[rnd.Next(5)]) + " " + verbit[rnd.Next(5)] + " ja " + substantiivit[rnd.Next(4)] + " " + verbit[rnd.Next(5)] + ".");
                    counter++;
                    break;
                case 2:
                    lauseet.Add((Capitalize(substantiivit[rnd.Next(x)]) + " " + verbit[rnd.Next(x)] + ", " + verbit[rnd.Next(x)] + " ja " + verbit[rnd.Next(x)] + "."));
                    //Console.WriteLine(Capitalize(substantiivit[rnd.Next(5)]) + " " + verbit[rnd.Next(5)] + ", " + verbit[rnd.Next(5)] + " ja " + verbit[rnd.Next(5)] + ".");
                    counter++;
                    break;
                case 3:
                    lauseet.Add("Miksi " + substantiivit[rnd.Next(x)] + " " + verbit[rnd.Next(x)] + "?");
                    //Console.WriteLine("Miksi " + substantiivit[rnd.Next(5)] + " " + verbit[rnd.Next(5)] + "?");
                    counter++;
                    break;
                case 4:
                    lauseet.Add("Onko " + substantiivit[rnd.Next(x)] + " todellinen?");
                    //Console.WriteLine("Onko " + substantiivit[rnd.Next(5)] + " todellinen?");
                    counter++;
                    break;
                case 5:
                    lauseet.Add(Capitalize(substantiivit[rnd.Next(x)]) + " haluu " + verbit[rnd.Next(x)] + " mutta ei voi, koska " + substantiivit[rnd.Next(x)] + " " + verbit[rnd.Next(x)]);
                    counter++;
                    break;
            }
        } while (counter < lkm);
        TulostaLauseet();
    }

    private void TulostaLauseet()
    {
        foreach (String lause in lauseet)
        {
            Console.WriteLine(lause);
        }
    }
    private String Capitalize(String str)
    {
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    public void makeFile()
    {
        String str;
        Console.Write("Anna tiedoston nimi >");
        str = Console.ReadLine();

        try
        {
            File.WriteAllLines("c:\\Users\\" + Environment.UserName + "\\Desktop\\" + str + ".txt", lauseet);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Test()
    {
        int i = 0;
        Random rnd = new Random();

        while (i < 50)
        {
            Console.WriteLine(substantiivit[rnd.Next(5)]);
            i++;
        }
    }
}