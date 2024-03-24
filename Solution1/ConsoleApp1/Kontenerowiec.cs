namespace ConsoleApp1;

public class Kontenerowiec
{
    public List<Kontener> ListaKontenerow = new List<Kontener>();

    protected int MaxPredkosc { get; set; }
    protected int MaxKontenery { get; set; }
    protected string NumerSeryjny { get; set; }
    protected int LiczbaKontenerow { get; set; }
    private static int numberIterator = 0;

    public Kontenerowiec(int maxPredkosc, int maxKontenery)
    {
        MaxPredkosc = maxPredkosc;
        MaxKontenery = maxKontenery;
        LiczbaKontenerow = 0;
        numberIterator++;
        NumerSeryjny = generateSerialNumber();
    }

    public void zaladujKontener(Kontener k)
    {
        ListaKontenerow.Add(k);
        LiczbaKontenerow++;
        Console.WriteLine("Zaladowano kontener " + k + " na statek " + this);
    }

    public void usunKontener(string id)
    {
        for (int i = ListaKontenerow.Count - 1; i >= 0; i--)
        {
            Kontener el = ListaKontenerow[i];
            if (el.getSerial().Equals(id))
            {
                ListaKontenerow.Remove(el);
                Console.WriteLine("Usunieto kontener " + el + " ze statku " + this);
                LiczbaKontenerow--;
            }
        }
    }
    public string generateSerialNumber()
    {
        numberIterator++;
        return "SHIP-" + numberIterator;
    }

    public void dodajListeKontenerow(List<Kontener> lk)
    {
        foreach (Kontener k in lk)
        {
            ListaKontenerow.Add(k);
            LiczbaKontenerow++;
        }
    }

    public void zamienKontenery(string id, Kontener kk)
    {
        for (int i = ListaKontenerow.Count - 1; i >= 0; i--)
        {
            if (ListaKontenerow[i].getSerial().Equals(id))
            {
                ListaKontenerow[i] = kk;
            }
        }
    }

    public override string ToString()
    {
        return NumerSeryjny;
    }
}