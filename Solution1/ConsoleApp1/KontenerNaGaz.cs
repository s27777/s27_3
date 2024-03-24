namespace ConsoleApp1;

public class KontenerNaGaz : Kontener, IHazardNotifier
{
    protected int MasaNetto { get; set; }
    protected int MasaWlasna { get; set; }
    protected int MasaBrutto { get; set; }
    protected int Wysokosc { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerSeryjny { get; set; }
    protected int Ladownosc { get; set; }
    protected float Cisnienie { get; set; }
    private static int numberIterator = 0;
    public KontenerNaGaz(int masawlasna, int wysokosc, int glebokosc, int ladownosc, float cisnienie) : 
        base(masawlasna, wysokosc, glebokosc, ladownosc)
    {
        MasaNetto = 0;
        MasaWlasna = masawlasna;
        MasaBrutto = MasaNetto + MasaWlasna;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        NumerSeryjny = generateSerialNumber();
        Ladownosc = ladownosc;
        Cisnienie = cisnienie;
        
        
    }
    public override string generateSerialNumber()
    {
        string nr = "";
        numberIterator++;
        nr = "KON-G-" + numberIterator;
        return nr;
    }

    public string getSerial()
    {
        return this.NumerSeryjny;
    }

    public void oproznienie()
    {
        // base.oproznienie();
        int poOproznieniu = (int)(MasaNetto * 0.05);
        MasaNetto = poOproznieniu;
        MasaBrutto = MasaWlasna + poOproznieniu;
        Console.WriteLine("Oprozniono kontener " + NumerSeryjny);
        Console.WriteLine("Aktualna masa netto: " + MasaNetto);
    }

    public void zaladowanie(int masa)
    {
        base.zaladowanie(masa);
    }

    public override string ToString()
    {
        return this.NumerSeryjny;
    }
    
}