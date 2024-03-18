namespace ConsoleApp1;

public class KontenerNaPlyny : Kontener
{
    public KontenerNaPlyny(int masaNetto, int masaBrutto, int wysokosc, int glebokosc, int numerSeryjny, int ladownosc) : 
        base(masaNetto, masaBrutto, wysokosc, glebokosc, numerSeryjny, ladownosc)
    {
        
    }

    public override void Oproznienie()
    {
        base.Oproznienie();
    }
}