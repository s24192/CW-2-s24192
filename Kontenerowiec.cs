using System.Collections;

namespace proj_1;

public class Kontenerowiec
{
    private string Nazwa { get; set; }
    private ArrayList Kontenery {get; set; }
    private int maksymalnaPrędkosc {get; set; }
    private int maksymalnaLiczbaKontenerow{get; set; }
    private double maksymalnaWagaKontenerow{get; set; }
    protected double aktualnaMasa = 0;
    private int atkualnaLiczbaKontenerów = 0;
    public Kontenerowiec(string Nazwa, int maksymalnaPrędkosc, int maksymalnaLiczbaKontenerow, double maksymalnaWagaKontenerow)
    {
        this.Nazwa = Nazwa;
        Kontenery = new ArrayList();
        this.maksymalnaPrędkosc = maksymalnaPrędkosc;
        this.maksymalnaLiczbaKontenerow = maksymalnaLiczbaKontenerow;
        this.maksymalnaWagaKontenerow = maksymalnaWagaKontenerow;

    }

    public void printInfo()
    {
        Console.WriteLine( "Top speed: " + maksymalnaPrędkosc + "\nMax load (tons): " + maksymalnaWagaKontenerow +
               "\nLoaded containers");
        foreach (Kontener k in Kontenery)
            Console.WriteLine(k.getInfo());
        
    }

    public void addKontener(Kontener kont)
    {
        if ((kont.getMasaLadunku() + kont.getWagaWlasna()) <=  (maksymalnaWagaKontenerow-aktualnaMasa) && atkualnaLiczbaKontenerów < maksymalnaLiczbaKontenerow)
        {
            Kontenery.Add(kont);
            this.aktualnaMasa = aktualnaMasa +  kont.getMasaLadunku();
            Console.WriteLine(this.aktualnaMasa);
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
            Kontenery.AddRange(KontenerList);
            aktualnaMasa += sumaMasy;
        }
        Console.WriteLine("Nie można dodać kontenerów");
    }

    public bool removeKontener(string numerSeryjnyKontenera)
    {
        foreach (Kontener k in Kontenery)
        {
            if (k.getNumerSeryjny() == numerSeryjnyKontenera)
            {
                Kontenery.Remove(k);
                return true;
            }
        }
        Console.WriteLine("Nie można znaleźć kontenera!");
        return false;
    }

    public void swapKontener(string numerSeryjnyKontenera,Kontener kont)
    {
        if (removeKontener(numerSeryjnyKontenera))
        {
            addKontener(kont);
        }
        else
        {
            Console.WriteLine("Nie znaleziono kontenera do zamiany!");
        }
    }
}