namespace Rema1000.ReponseModels;

public class RemaResponse
{
    public string Name { get; set; }
    public string Underline { get; set; }
    public List<PriceModel>? Prices { get; set; }
    public List<NutritionInfo>? NutritionInfo { get; set; }
    public List<ImageUrls>? Images { get; set; }
    public double NormalPrice => (double) Prices.Where(p => !p.IsCampaign).First().Price;
    
    public int? Grams {
        get {
            string[] parts = Underline.Split(' ');

            if (int.TryParse(parts[0], out int number))
            {
                return number;
            }

            return null;
        }
    }

    public int? Calories {
        get {
            if (NutritionInfo.Count == 0) 
            {
                return null;
            }

            var energy = NutritionInfo.Where(n => n.Name == "Energi").First();
            // Format: "  2.050 KJ /   497 kcal"
            var energyValue = energy.Value;

            string[] parts = energyValue.Split('/');
            parts = parts[1].Trim().Split(' ');

            if (int.TryParse(parts[0], out int number))
            {
                return number;
            }

            return null;
        }
    }

    public RemaResponse(dynamic data) {
        Name = data.name;
        Underline = data.underline;
        
        Prices = new List<PriceModel>();
        foreach (var priceData in data.prices)
        {
            Prices.Add(new PriceModel(priceData));
        }

        NutritionInfo = new List<NutritionInfo>();
        foreach (var nutriData in data.nutrition_info)
        {
            NutritionInfo.Add(new NutritionInfo(nutriData));
        }

        Images = new List<ImageUrls>();
        foreach (var imageData in data.images)
        {
            Images.Add(new ImageUrls(imageData));
        }        
    }
}
