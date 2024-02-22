namespace Rema1000.ReponseModels;

public class NutritionInfo
{
    public string? Name { get; set; }
    public string? Value { get; set; }

    public NutritionInfo(dynamic data)
    {
        Name = data.name;
        Value = data.value;
    }
}
