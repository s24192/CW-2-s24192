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
        throw new HazardException("Niebezpieczne wydarzenie!!!");
    }

    public void oproznienieLadunku()
    {
        this.MasaLadunku = MasaLadunku * 0.05;
    }

    public void zaladowanieLadunku(int masaZaladunku)
    {
        if (masaZaladunku > MaksymalnaLadownosc)
        {
            throw new OverfillException("Próbowano załadować za dużo gazu");
        }
        this.MasaLadunku = masaZaladunku;
    }

    public string getInfo()
    {
        return "Kontener na gaz: " + this.NumerSeryjny;
    }
}