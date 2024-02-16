namespace Models;

public class PackingTypes
{
    public static List<PackingType> Alle => 
        new List<PackingType> {
            PackingType.Karton,
            PackingType.Dåse,
            PackingType.Enhed,
            PackingType.Flaske,
            PackingType.Glas,
            PackingType.Pakke,
            PackingType.Pose,
            PackingType.Stk,
        };
}

public enum PackingType 
{
    Karton,
    Dåse,
    Enhed,
    Flaske,
    Glas,
    Pakke,
    Pose,
    Stk,
}
