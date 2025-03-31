using System.Collections;

namespace proj_1;

public class Kontenerowiec
{
    private string Nazwa { get; set; }
    private ArrayList kontenery;
    private int maksymalnaPrędkosc;
    private int maksymalnaLiczbaKontenerow;
    private double maksymalnaWagaKontenerow;
    private double aktualnaMasa = 0;
    private int atkualnaLiczbaKontenerów = 0;
    public Kontenerowiec(string Nazwa, int maksymalnaPrędkosc, int maksymalnaLiczbaKontenerow, double maksymalnaWagaKontenerow)
    {
        this.Nazwa = Nazwa;
        kontenery = new ArrayList();
        this.maksymalnaPrędkosc = maksymalnaPrędkosc;
        this.maksymalnaLiczbaKontenerow = maksymalnaLiczbaKontenerow;
        this.maksymalnaWagaKontenerow = maksymalnaWagaKontenerow;

    }

    public void printInfo()
    {
        Console.WriteLine( "Top speed: " + maksymalnaPrędkosc + "\nMax load (tons): " + maksymalnaWagaKontenerow +
               "\nLoaded containers");
        foreach (Kontener k in kontenery)
            Console.WriteLine(k.getInfo());
        
    }

    public void addKontener(Kontener kont)
    {
        if (kont.getMasaLadunku() <= aktualnaMasa && atkualnaLiczbaKontenerów < maksymalnaLiczbaKontenerow)
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

    public void addKontenerList(List<Kontener> KontenerList)
    {
        double sumaMasy = 0;
        foreach (var kontener in KontenerList)
        {
            sumaMasy += kontener.getMasaLadunku() + kontener.getWagaWlasna();
        }
        if (KontenerList.Count < maksymalnaLiczbaKontenerow && sumaMasy + aktualnaMasa > maksymalnaWagaKontenerow )
        {
            kontenery.AddRange(KontenerList);
        }
        Console.WriteLine("Nie można dodać kontenerów");
    }
}