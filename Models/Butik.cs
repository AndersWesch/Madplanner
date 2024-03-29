namespace Models;

public class Butikker
{
    public static List<Butik> Alle => 
        new List<Butik> {
            Butik.Ana,
            Butik.Coop365,
            Butik.Fotex,
            Butik.Kvickly,
            Butik.Lidl,
            Butik.Lovbjerg,
            Butik.Netto,
            Butik.Rema1000,
        };
}

public enum Butik
{
    Ana,
    Coop365,
    Fotex,
    Kvickly,
    Lidl,
    Lovbjerg,
    Netto,
    Rema1000,
}
