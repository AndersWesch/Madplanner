namespace Models;

public class Categories
{
    public static List<Category> Alle => 
        new List<Category> {
            Category.Amerikansk,
            Category.Andet,
            Category.Asiatisk,
            Category.Dansk,
            Category.Indisk,
            Category.Italiensk,
            Category.Italiensk,
            Category.Salat,
            Category.Sandwich,
            Category.Spansk,
            Category.Suppe,
        };
}

public enum Category
{
    Amerikansk,
    Andet,
    Asiatisk,   
    Dansk,
    Indisk,
    Italiensk,
    Mexikansk,
    Salat,
    Sandwich,
    Spansk,
    Suppe,
}
