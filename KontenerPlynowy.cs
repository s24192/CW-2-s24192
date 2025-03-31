namespace proj_1;

public class KontenerPlynowy : Kontener, IHazradModifier
{
    private static int number = 0;
    public KontenerPlynowy( int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc) 
        : base( wysokosc, wagaWlasna, glebokosc,  maksymalnaLadownosc)
    {
        base.NumerSeryjny = "KON-L-" + number;
        number++;
    }

    public void hazardSituation()
    {
        throw new HazardException("Niebezpieczne wydarzenie!!!");
    }
    public string getInfo()
    {
        return "Kontener na plyny: " + this.NumerSeryjny;
    }
}