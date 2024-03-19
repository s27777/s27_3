namespace ConsoleApp1;

public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    public KontenerNaPlyny(int masaNetto, int masaBrutto, int wysokosc, int glebokosc, string numerSeryjny, int ladownosc) : 
        base(masaNetto, masaBrutto, wysokosc, glebokosc, numerSeryjny, ladownosc)
    {
        
    }

    public override void Oproznienie()
    {
        base.Oproznienie();
    }
}

public interface IHazardNotifier
{
    void Powiadomienie()
    {
        Console.WriteLine();
    }
    
}