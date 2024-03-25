namespace ConsoleApp1;

public class KontenerChlodniczy : Kontener, IHazardNotifier
{
    protected int MasaNetto { get; set; }
    protected int MasaWlasna { get; set; }
    protected int MasaBrutto { get; set; }
    protected int Wysokosc { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerSeryjny { get; set; }
    protected int Ladownosc { get; set; }
    protected string Produkt { get; set; }
    protected int Temperatura { get; set; }
    private static int numberIterator = 0;
    public KontenerChlodniczy(int masawlasna, int wysokosc, int glebokosc, int ladownosc, string produkt, int temperatura) : 
        base(masawlasna, wysokosc, glebokosc, ladownosc)
    {
        MasaNetto = 0;
        MasaWlasna = masawlasna;
        MasaBrutto = MasaNetto + MasaWlasna;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        NumerSeryjny = generateSerialNumber();
        Ladownosc = ladownosc;
        Produkt = produkt;
        Temperatura = temperatura;
    }
    public override string generateSerialNumber()
    {
        string nr = "";
        numberIterator++;
        nr = "KON-C-" + numberIterator;
        return nr;
    }

    public string getSerial()
    {
        return this.NumerSeryjny;
    }

    public void oproznienie()
    {
        base.oproznienie();
    }

    public void zaladowanie(int masa)
    {
        base.zaladowanie(masa);
    }

    public void info()
    {
        Console.WriteLine("Dane kontenera " + NumerSeryjny + ":");
        Console.WriteLine("Masa ładunku (netto): " + MasaNetto);
        Console.WriteLine("Masa brutto: " + MasaBrutto);
    }

    public int getBrutto()
    {
        return base.getBrutto();
    }
    
    public override string ToString()
    {
        return this.NumerSeryjny;
    }
}