namespace proj_1;

public class KontenerChlodniczy : Kontener
{
    private static int number = 0;
    private double Temperatura;
    private string RodzajProduktu;
    
    public KontenerChlodniczy( int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc, string rodzajProduktu) 
        : base( wysokosc, wagaWlasna, glebokosc,  maksymalnaLadownosc)
    {
        base.NumerSeryjny = "KON-C-" + number;
        number++;
        this.RodzajProduktu = rodzajProduktu;
    }
    public string getInfo()
    {
        return "Kontener chlodniczy: " + this.NumerSeryjny;
    }
}