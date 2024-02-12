namespace Models;

public class Dage
{
    public static List<Dag> AlleDage => 
        new List<Dag> {
            Dag.Mandag,
            Dag.Tirsdag,
            Dag.Onsdag,
            Dag.Torsdag,
            Dag.Fredag,
            Dag.Lørdag,
            Dag.Søndag
        };
}

public enum Dag
{
    Mandag,
    Tirsdag,
    Onsdag,
    Torsdag,
    Fredag,
    Lørdag,
    Søndag
}
