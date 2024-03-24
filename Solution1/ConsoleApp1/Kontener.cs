namespace ConsoleApp1;
public abstract class Kontener
{
    
    protected int MasaNetto { get; set; }
    protected int MasaWlasna { get; set; }
    protected int MasaBrutto { get; set; }
    protected int Wysokosc { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerSeryjny { get; set; }
    protected int Ladownosc { get; set; }

    protected Kontener(int masawlasna, int wysokosc, int glebokosc, int ladownosc)
    {
        MasaNetto = 0;
        MasaWlasna = masawlasna;
        MasaBrutto = masawlasna;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        NumerSeryjny = generateSerialNumber();
        Ladownosc = ladownosc;
    }

    public virtual string generateSerialNumber()
    {
        NumerSeryjny = "";
        return NumerSeryjny;
    }

    public virtual void oproznienie()
    { 
        MasaNetto = 0;
        MasaBrutto = MasaWlasna;
        Console.WriteLine("Kontener " + NumerSeryjny + " zostal oprozniony " + MasaNetto + " | " + MasaBrutto);
    }

    public virtual void zaladowanie(int masa)
    {
        if (masa > Ladownosc)
        {
            throw new OverfillException("OverfillException");
        }
        
        this.MasaNetto = MasaNetto + masa;
        this.MasaBrutto = MasaBrutto + masa;
        Console.WriteLine("Zaladowano kontener " + NumerSeryjny);
        Console.WriteLine("Aktualna masa netto: " + MasaNetto + ", brutto: " + MasaBrutto);
    }

    public virtual string getSerial()
    {
        return this.NumerSeryjny;
    }

    Exception OverfillException()
    {
        String lkjh = "aberty";
        return new Exception();
    }

    public override string ToString()
    {
        return this.NumerSeryjny;
    }
    
}


