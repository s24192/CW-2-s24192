namespace proj_1;

public class Kontener
{
    protected static int number = 0;
    protected int Wysokosc;
    protected int WagaWlasna;
    protected int Glebokosc;
    protected string NumerSeryjny;
    protected double MasaLadunku;
    protected int MaksymalnaLadownosc;

    public Kontener( int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc)
    {
        this.MasaLadunku = 0;
        this.Wysokosc = wysokosc;
        this.WagaWlasna = wagaWlasna;
        this.Glebokosc = glebokosc;
        this.NumerSeryjny = "KON-" + number;
        number++;
        this.MaksymalnaLadownosc = maksymalnaLadownosc;
    }

    public void oproznienieLadunku()
    {
        MasaLadunku = 0;
        
    }

    public void zaladaowanieLafunku(int masaLadunku)
    {
        if (masaLadunku > MaksymalnaLadownosc)
        {
            throw new OverfillException("Próbowano załadować za dużo ładunku");
        }
        this.MasaLadunku = masaLadunku;
    }

    public double getMasaLadunku()
    {
        return MasaLadunku;
    }

    public void printSerialNumber()
    {
        Console.WriteLine(NumerSeryjny);
    }

    public int getWagaWlasna()
    {
        return this.WagaWlasna;
    }

    public string getInfo()
    {
        return "Kontener: " + this.NumerSeryjny;
    }

    public string getNumerSeryjny()
    {
        return this.NumerSeryjny;
    }
}

public class OverfillException(string msg) : Exception(msg);