namespace Seeders;

public interface ISeeder<T>
{
    List<T> Seed();
}
