namespace ConsoleApp1;

public class Kontenerowiec
{
    public List<Kontener> ListaKontenerow = new List<Kontener>();

    protected int MaxPredkosc { get; set; }
    protected int MaxKontenery { get; set; }
    protected string NumerSeryjny { get; set; }
    private static int numberIterator = 0;

    public Kontenerowiec(int maxPredkosc, int maxKontenery)
    {
        MaxPredkosc = maxPredkosc;
        MaxKontenery = maxKontenery;
        numberIterator++;
        NumerSeryjny = generateSerialNumber();
    }

    public void zaladujKontener(Kontener k)
    {
        ListaKontenerow.Add(k);
        Console.WriteLine("Zaladowano kontener " + k + " na statek " + this);
    }
    public string generateSerialNumber()
    {
        numberIterator++;
        return "SHIP-" + numberIterator;
    }

    public override string ToString()
    {
        return NumerSeryjny;
    }
}