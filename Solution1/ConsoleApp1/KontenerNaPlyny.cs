using System.ComponentModel;

namespace ConsoleApp1;

public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    protected int MasaNetto { get; set; }
    protected int MasaWlasna { get; set; }
    protected int MasaBrutto { get; set; }
    protected int Wysokosc { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerSeryjny { get; set; }
    protected int Ladownosc { get; set; }
    protected bool Niebezpieczny { get; set; }
    private static int numberIterator = 0;
    public KontenerNaPlyny(int masawlasna, int wysokosc, int glebokosc, int ladownosc, bool niebezbieczny) : 
        base(masawlasna, wysokosc, glebokosc, ladownosc)
    {
        MasaNetto = 0;
        MasaWlasna = masawlasna;
        MasaBrutto = MasaNetto + MasaWlasna;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        NumerSeryjny = generateSerialNumber();
        Ladownosc = ladownosc;
        Niebezpieczny = niebezbieczny;
    }

    public override string generateSerialNumber()
    {
        string nr = "";
        numberIterator++;
        nr = "KON-L-" + numberIterator;
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
    
    public int getBrutto()
    {
        return base.getBrutto();
    }
    
    public void info()
    {
        Console.WriteLine("Dane kontenera " + NumerSeryjny + ":");
        Console.WriteLine("Masa ładunku (netto): " + MasaNetto);
        Console.WriteLine("Masa brutto: " + MasaBrutto);
    }

    public void zaladowanie(int masaLadunku, IHazardNotifier ihn)
    {
        //base.zaladowanie(masa);
        int maxLoad;
        if (Niebezpieczny == true) { maxLoad = (int)(Ladownosc * 0.5); }
        else { maxLoad = (int)(Ladownosc * 0.9); }

        if (masaLadunku > Ladownosc)
        {
            throw new OverfillException("OverfillException");
        }
        else if (masaLadunku > maxLoad)
        {
            ihn.Powiadomienie("IHazardNotifier: sytuacja niebezpieczna w kontenerze " + NumerSeryjny);
        }

        MasaNetto += masaLadunku;
        MasaBrutto += masaLadunku;
        Console.WriteLine("Zaladowano kontener " + NumerSeryjny + " ladunkiem " + masaLadunku);
        Console.WriteLine("Aktualna masa brutto: " + MasaBrutto);
    }
    
    public override string ToString()
    {
        return this.NumerSeryjny;
    }
}

public interface IHazardNotifier
{
    void Powiadomienie(string message)
    {
        Console.WriteLine(message);
        //throw new OverfillException();
    }
    
}