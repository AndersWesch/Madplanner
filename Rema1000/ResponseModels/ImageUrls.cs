namespace Rema1000.ReponseModels;

public class ImageUrls
{
    public string? Small { get; set; }
    public string? Medium { get; set; }
    public string? Large { get; set; }

    public ImageUrls(dynamic data)
    {
        Small = data.small;
        Medium = data.medium;
        Large = data.large;
    }
}
