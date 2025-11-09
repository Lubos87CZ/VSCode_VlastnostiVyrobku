using System;

namespace VlastnostiVyrobku;

public class Vyrobek
{public string NazevVyrobku { get; private set; }
    public string PopisVyrobku { get; private set; }
    public bool Tezky { get; private set; }
    private double hmotnostVyrobku; //privatni promena, budu rozhodovat o tezkosti na zaklade hmotnosti
    public double HmotnostVyrobku
    {
        get
        {
            return hmotnostVyrobku; // pracuji v getteru s privatnim atributem hmotnsot
        }

        set
        {
            hmotnostVyrobku = value; //ulozim hodnotu hmotnosti do lokalniho atributu hmotnost
            Tezky = false; //nastavim vlastnost Tezky 
            if (hmotnostVyrobku > 5)  //kontrola hmotnosti
            {
                Tezky = true;
            }
        }
    }

    public Vyrobek(string nazevVyrobku, string popisVyrobku, double hmotnostVyrobku)
    //parametry konstruktoru vzdy malym
    {
        //volam verejnou metodu ktera nic nevraci pro nastaveni vlasnosti instance
        EditujVyrobek(nazevVyrobku, popisVyrobku, hmotnostVyrobku);
    }

    public void EditujVyrobek(string nazevVyrobku, string popisVyrobku, double hmotnostVyrobku)
    //void - prazdnota,prazdny                
    {
        //nastavim hodnoty vlastnosti instance
        NazevVyrobku = nazevVyrobku;
        PopisVyrobku = popisVyrobku;
        HmotnostVyrobku = hmotnostVyrobku;
    }

    public string VypisVyrobek()
    {
        string s1 = NazevVyrobku;
        string s2 = PopisVyrobku;
        string s3 = HmotnostVyrobku.ToString();
        string s4;
        string s;

        if (Tezky)
            s4 = "tezky";
        else
            s4 = "lehky";
        s = String.Format("Nazev vyrobku: {0}\nPopis vyrobku: {1}\nHmotnost vyrobku:{2} kg, tj. {3} vyrobek", s1, s2, s3, s4);
        return s;
    }

}
