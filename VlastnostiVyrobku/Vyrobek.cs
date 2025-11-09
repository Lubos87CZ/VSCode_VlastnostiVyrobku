using System;

namespace VlastnostiVyrobku;

public class Vyrobek
{
    public string NazevVyrobku { get; private set; }
    public string PopisVyrobku { get; private set; }
    public bool Tezky { get; private set; }
    private double hmotnostVyrobku; //incializace privátního atributu
    public double HmotnostVyrobku
    {
        get
        {
            return hmotnostVyrobku;
        }
        set
        {
            hmotnostVyrobku = value; //pristup k zadane hodnote pomoci value
            //kontrola vahy
            Tezky = false;
            if (hmotnostVyrobku > 10.0)  //v setteru pracujeme s privatnim atributem
                Tezky = true;
        }
    }

    public Vyrobek(string nazevVyrobku, string popisVyrobku, double hmotnostVyrobku)
    {
        EditujVyrobek(nazevVyrobku, popisVyrobku, hmotnostVyrobku);  //volame verejnou proceduru pro editaci vyrobku s parametry z konstruktoru
    }

    /// <summary>
    /// Edituje parametry vyrobku
    /// </summary>
    /// <param name="nazevVyrobku">nazev vyrobku</param>
    /// <param name="popisVyrobku">popis</param>
    /// <param name="hmotnostVyrobku">hmotnost [kg]</param>
    public void EditujVyrobek(string nazevVyrobku, string popisVyrobku, double hmotnostVyrobku)
    {
        NazevVyrobku = nazevVyrobku;
        PopisVyrobku = popisVyrobku;
        HmotnostVyrobku = hmotnostVyrobku;
    }

    public override string ToString()
    {
        string jeTezky = "tezky";
        if (!Tezky)
            jeTezky = "lehky";
        
        return String.Format("Vyrobek: {0} \nPopis vyrobku:{1}\nHmotnost vyrobku:{2} a je {3}",NazevVyrobku,PopisVyrobku,HmotnostVyrobku,jeTezky);
    }
        
    

}
