
public class Sanataulu
{
    private String[] taulu;

    public Sanataulu()
    {
        taulu = new String[5];
    }

    public void Tayta()
    {
        for (int i = 0; i < taulu.Length; i++)
        {
            Console.Write((i + 1) + ". >");
            String str = Console.ReadLine();
            taulu[i] = str;
        }
    }

    public String[] GetTaulu()
    {
        return taulu;
    }
}
