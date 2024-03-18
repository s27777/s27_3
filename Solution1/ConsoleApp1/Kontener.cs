namespace ConsoleApp1;
public abstract class Kontener
{
    
    protected int MasaNetto { get; }
    protected int MasaBrutto { get; }
    protected int Wysokosc { get; }
    protected int Glebokosc { get; }
    protected string NumerSeryjny { get; }
    protected int Ladownosc { get; }

    protected Kontener(int masaNetto, int masaBrutto, int wysokosc, int glebokosc, string numerSeryjny, int ladownosc)
    {
        MasaNetto = masaNetto;
        MasaBrutto = MasaBrutto;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        NumerSeryjny = numerSeryjny;
        Ladownosc = ladownosc;
    }

    public virtual void Oproznienie()
    {
        MasaNetto = 0;
    }
    
    
}


