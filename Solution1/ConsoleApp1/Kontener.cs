namespace ConsoleApp1;
public abstract class Kontener
{
    
    protected int MasaNetto { get; set; }
    protected int MasaBrutto { get; set; }
    protected int Wysokosc { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerSeryjny { get; set; }
    protected int Ladownosc { get; set; }

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


