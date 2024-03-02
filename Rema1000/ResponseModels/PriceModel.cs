using System.Globalization;

namespace Rema1000.ReponseModels;

public class PriceModel
{
    public double Price { get; set; }
    public bool IsCampaign { get; set; }
    public DateTime? StartingAt { get; set; }
    public DateTime? EndingAt { get; set; }

    public PriceModel(dynamic dataPrice)
    {
        Price = dataPrice.price;
        IsCampaign = dataPrice.is_campaign;

        // Format string date: 2021-12-23T00:00:00+00:00 to DateTime
        string starting_at = (string)dataPrice.starting_at;
        DateTime startDate = DateTime.ParseExact(starting_at, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        StartingAt = startDate;

        string ending_at = (string)dataPrice.ending_at;
        DateTime endDate = DateTime.ParseExact(ending_at, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        EndingAt = endDate;
    }
}
