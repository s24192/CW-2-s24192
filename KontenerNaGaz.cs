namespace proj_1;

public class KontenerNaGaz : Kontener, IHazradModifier
{
    private static int number = 0;
    public double Cisnienie;
    
    public KontenerNaGaz( int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc) 
        : base( wysokosc, wagaWlasna, glebokosc,  maksymalnaLadownosc)
    {
        base.NumerSeryjny = "KON-G-" + number;
        number++;
    }

    public void hazardSituation()
    {
        throw new NotImplementedException();
    }

    public void oproznienieLadunku()
    {
        this.MasaLadunku = MasaLadunku * 0.05;
    }
    public string getInfo()
    {
        return "Kontener na gaz: " + this.NumerSeryjny;
    }
}