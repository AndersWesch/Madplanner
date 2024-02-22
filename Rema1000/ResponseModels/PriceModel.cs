namespace Rema1000.ReponseModels;

public class PriceModel
{
    public decimal Price { get; set; }
    public bool IsCampaign { get; set; }
    public string? StartingAt { get; set; }
    public string? EndingAt { get; set; }

    public PriceModel(dynamic dataPrice)
    {
        Price = dataPrice.price;
        IsCampaign = dataPrice.is_campaign;
        StartingAt = dataPrice.starting_at;
        EndingAt = dataPrice.ending_at;
    }
}
