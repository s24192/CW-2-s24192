using System.Collections;

namespace proj_1;

public class Kontenerowiec
{
    private string Nazwa { get; set; }
    private ArrayList kontenery;
    private int maksymalnaPrędkosc;
    private int mkasymalnaLiczbaKontenerow;
    private double maksymalnaWagaKontenerow;
    private double aktualnaMasa = 0;
    private int atkualnaLiczbaKontenerów = 0;
    public Kontenerowiec(string Nazwa, int maksymalnaPrędkosc, int maksymalnaLiczbaKontenerow, double maksymalnaWagaKontenerow)
    {
        this.Nazwa = Nazwa;
        kontenery = new ArrayList();
        this.maksymalnaPrędkosc = maksymalnaPrędkosc;
        this.maksymalnaWagaKontenerow = maksymalnaLiczbaKontenerow;
        this.maksymalnaWagaKontenerow = maksymalnaWagaKontenerow;

    }

    public void printInfo()
    {
        Console.WriteLine( "Top speed: " + maksymalnaPrędkosc + "\nMax load (tons): " + maksymalnaWagaKontenerow +
               "\nLoaded containers");
        foreach (Kontenerowiec k in kontenery)
            Console.WriteLine(k);
        
    }

    public void addKontener(Kontener kont)
    {
        if (kont.getMasaLadunku() <= aktualnaMasa && atkualnaLiczbaKontenerów <= mkasymalnaLiczbaKontenerow)
        {
            kontenery.Add(kont);
            aktualnaMasa += kont.getMasaLadunku();
            atkualnaLiczbaKontenerów++;

        }
        else
        {
            Console.WriteLine("Nie można dodać kontenera");
        }
    }
}